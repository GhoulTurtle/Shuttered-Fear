using System;
using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInventoryHandler : MonoBehaviour{
    [Header("Input Variables")]
    [SerializeField] private float inputLockoutTime = 0.5f;

    [Header("Scriptable Object Required References")]
    [SerializeField] private PlayerInventorySO currentInventory;
    [SerializeField] private PlayerInventoryRecipeListSO currentInventoryRecipeList;

    public InventoryState CurrentInventoryState => currentInventoryState;

    private InventoryState currentInventoryState = InventoryState.Closed;

    public EventHandler<InventoryStateChangedEventArgs> OnInventoryStateChanged;
    public class InventoryStateChangedEventArgs : EventArgs{
        public InventoryState inventoryState;
        public InventoryStateChangedEventArgs(InventoryState _inventoryState){
            inventoryState = _inventoryState;
        }
    }

    public EventHandler<SetupInventoryEventArgs> OnSetupInventory;
    public class SetupInventoryEventArgs : EventArgs{
        public PlayerInventorySO playerInventorySO;
        public SetupInventoryEventArgs(PlayerInventorySO _playerInventorySO){
            playerInventorySO = _playerInventorySO;
        }
    }

    private PlayerInputHandler playerInputHandler;

    private bool inputValid = true;

    private void Awake() {
        TryGetComponent(out playerInputHandler);
    }

    private void Start() {
        SetupInventory();
    }

    private void OnDestroy() {
        if(playerInputHandler == null) return;

        playerInputHandler.OnCancelInput -= ExitInventoryUIInput;
        StopAllCoroutines();
    }

    public void InventoryInput(InputAction.CallbackContext context){
        if(context.phase != InputActionPhase.Performed) return;

        UpdateInventoryState(InventoryState.Default);
    }

    public void SetupInventory(){
        OnSetupInventory?.Invoke(this, new SetupInventoryEventArgs(currentInventory));
    }

    public void UpdateInventoryState(InventoryState inventoryState){
        if(currentInventoryState == inventoryState) return;

        StartCoroutine(InputLockoutCoroutine());

        switch (inventoryState){
            case InventoryState.Closed: ClosedInventoryState();
                break;
            case InventoryState.Default: DefaultInventoryState();
                break;
            case InventoryState.ContextUI: ContextUIInventoryState();
                break;
            case InventoryState.Combine: CombineInventoryState();
                break;
            case InventoryState.Inspect: InspectInventoryState();
                break;
        }

        OnInventoryStateChanged?.Invoke(this, new InventoryStateChangedEventArgs(inventoryState));

        currentInventoryState = inventoryState;
    }

    public string AttemptItemCombination(InventoryItem initalComboItem, InventoryItem incomingItem){
        ComboResult newComboResult = new ComboResult();

        if(initalComboItem.GetHeldItem() == incomingItem.GetHeldItem() && initalComboItem.IsFull() || 
           initalComboItem.GetHeldItem() == incomingItem.GetHeldItem() && incomingItem.IsFull()){
            newComboResult.SetComboResult(ComboResultType.Invalid_Stack_Combo, null);
            return GetCombineResultMessage(newComboResult);
        }
    
        if(initalComboItem.GetHeldItem() == incomingItem.GetHeldItem() && !initalComboItem.IsFull() && !incomingItem.IsFull()){
            int remainingStack = currentInventory.AttemptToStackItems(incomingItem, initalComboItem);
            if(remainingStack != 0){
                initalComboItem.SetStack(remainingStack);
            }
            else{
                initalComboItem.ClearItem();
            }

            newComboResult.SetComboResult(ComboResultType.Valid_Stack_Combo, incomingItem);
            return GetCombineResultMessage(newComboResult);
        }

        //if initalcomboitem is a resource and the incoming item is a weapon the return either INVALIDWEAPONRESOURCECOMBO, VALIDWEAPONRESOUCECOMBO, or FULLWEAPON
        //if initalcomboitem is a resource and the incoming item is a tool the return either INVALIDTOOLRESOURCECOMBO, VALIDTOOLRESOUCECOMBO or FULLTOOL

        InventoryItem attemptedItemCombo = currentInventoryRecipeList.ReturnValidInventoryRecipeResult(initalComboItem.GetHeldItem(), incomingItem.GetHeldItem());
        if(attemptedItemCombo == null){
            newComboResult.SetComboResult(ComboResultType.Invalid_Combo, null);
            return GetCombineResultMessage(newComboResult);
        }

        if(attemptedItemCombo != null){
            //Hold a temp reference to the items before removing them incase we don't have room in the inventory
            ItemDataSO initalComboItemData = initalComboItem.GetHeldItem();
            ItemDataSO incomingItemData = incomingItem.GetHeldItem();

            initalComboItem.RemoveFromStack(1);
            incomingItem.RemoveFromStack(1);

            int remainingItems = currentInventory.AttemptToAddItemToInventory(attemptedItemCombo.GetHeldItem(), attemptedItemCombo.GetCurrentStack());

            if(remainingItems != 0){
                //Add back the items into the inventory
                currentInventory.AttemptToAddItemToInventory(initalComboItemData, 1);
                currentInventory.AttemptToAddItemToInventory(incomingItemData, 1);

                newComboResult.SetComboResult(ComboResultType.Full_Inventory, attemptedItemCombo);
                return GetCombineResultMessage(newComboResult);
            }

            newComboResult.SetComboResult(ComboResultType.Valid_Combo, attemptedItemCombo);
            return GetCombineResultMessage(newComboResult);
        }

        return "INVALID ITEM COMBINATION";
    }

    private string GetCombineResultMessage(ComboResult comboResult){
        return comboResult.GetComboResultType() switch{
            ComboResultType.Invalid_Combo => "Can't combine those.",
            ComboResultType.Invalid_Weapon_Resource_Combo => "Wrong ammo type.",
            ComboResultType.Invalid_Tool_Resource_Combo => "Wrong type of resource.",
            ComboResultType.Invalid_Stack_Combo => "Can't stack those.",
            ComboResultType.Valid_Combo => "Made " + comboResult.GetResultItemName() + " X" + comboResult.GetResultItemStack() + ".",
            ComboResultType.Valid_Stack_Combo => "Successfully Stacked " + comboResult.GetResultItemName() + " X" + comboResult.GetResultItemStack() + ".",
            ComboResultType.Valid_Weapon_Resource_Combo => "Loaded " + comboResult.GetResultItemName(),
            ComboResultType.Valid_Tool_Resource_Combo => "Recharged " + comboResult.GetResultItemName(),
            ComboResultType.Full_Weapon => comboResult.GetResultItemName() + " is already loaded.",
            ComboResultType.Full_Tool => comboResult.GetResultItemName() + " is already charged.",
            ComboResultType.Full_Inventory => "Can't hold anymore items.",
            _ => "ERROR NO COMBO RESULT TYPE FOUND",
        };
    }

    private IEnumerator InputLockoutCoroutine(){
        inputValid = false;
        yield return new WaitForSeconds(inputLockoutTime);
        inputValid = true;
    }

    private void InspectInventoryState(){
        playerInputHandler.OnCancelInput -= ExitInventoryUIInput;
        playerInputHandler.OnCancelInput -= ReturnDefaultInventoryUIInput;
        playerInputHandler.OnCancelInput += ReturnToContextUIInput;
    }

    private void CombineInventoryState(){
        playerInputHandler.OnCancelInput -= ExitInventoryUIInput;
        playerInputHandler.OnCancelInput -= ReturnDefaultInventoryUIInput;
        playerInputHandler.OnCancelInput += ReturnToContextUIInput;
    }

    private void ContextUIInventoryState(){
        playerInputHandler.OnCancelInput -= ExitInventoryUIInput;
        playerInputHandler.OnCancelInput -= ReturnToContextUIInput;
        playerInputHandler.OnCancelInput += ReturnDefaultInventoryUIInput;
    }

    private void DefaultInventoryState(){
        GameManager.UpdateGameState(GameState.UI);
        playerInputHandler.OnCancelInput -= ReturnDefaultInventoryUIInput;
        playerInputHandler.OnCancelInput -= ReturnToContextUIInput;
        playerInputHandler.OnCancelInput += ExitInventoryUIInput;
    }

    private void ClosedInventoryState(){
        playerInputHandler.OnCancelInput -= ReturnDefaultInventoryUIInput;
        playerInputHandler.OnCancelInput -= ReturnToContextUIInput;
        playerInputHandler.OnCancelInput -= ExitInventoryUIInput;
        GameManager.UpdateGameState(GameState.Game);
    }

    private void ReturnToContextUIInput(object sender, PlayerInputHandler.InputEventArgs e){
        if(!inputValid) return;

        if(e.inputActionPhase != InputActionPhase.Started) return;
        UpdateInventoryState(InventoryState.ContextUI);
    }

    private void ReturnDefaultInventoryUIInput(object sender, PlayerInputHandler.InputEventArgs e){
        if(!inputValid) return;

        if(e.inputActionPhase != InputActionPhase.Started) return;
        UpdateInventoryState(InventoryState.Default);
    }

    private void ExitInventoryUIInput(object sender, PlayerInputHandler.InputEventArgs e){
        if(!inputValid) return;

        if(e.inputActionPhase != InputActionPhase.Started) return;
        UpdateInventoryState(InventoryState.Closed);
    }

    public PlayerInventorySO GetInventory(){
        return currentInventory;
    }

    public void SetInventory(PlayerInventorySO playerInventorySO){
        currentInventory = playerInventorySO;
    }

    public PlayerInventoryRecipeListSO GetRecipeList(){
        return currentInventoryRecipeList;
    }

    public void SetRecipeList(PlayerInventoryRecipeListSO inventoryRecipeListSO){
        currentInventoryRecipeList = inventoryRecipeListSO;
    }
}
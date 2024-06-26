using System;
using System.Collections;
using UnityEngine;

public abstract class EquippedItemBehaviour : MonoBehaviour{
    [Header("Item State Variables")]
    [SerializeField] private EquippableItemState defaultItemState;
    [SerializeField] private EquippableItemHolsterType defaultItemHolsterType;

    [Header("Weapon State Variables")]
    [SerializeField] private ChildBehaviourData aimedChildData;
    [SerializeField] private ChildBehaviourData inspectingChildData;
    [SerializeField] private ChildBehaviourData reloadingChildData;

    [Header("Holster Variables")]
    [SerializeField] private bool playHolsterAnimation;
    [SerializeField] private float holsterAnimationDuration = 0.35f;

    protected WeaponState currentWeaponState = WeaponState.Default;

    public EventHandler<WeaponStateChangedEventArgs> OnWeaponStateChanged;
    public class WeaponStateChangedEventArgs{
        public WeaponState weaponState;
        public WeaponStateChangedEventArgs(WeaponState _weaponState){
            weaponState = _weaponState;
        }
    }

    public EventHandler OnWeaponUse;
    public EventHandler OnWeaponAltUse;
    public EventHandler OnWeaponAltCancel;
    public EventHandler OnEmergencyItemUse;
    public EventHandler OnHolsterWeapon;
    public EventHandler OnUnholsterWeapon;
    public EventHandler OnReload;
    public EventHandler OnInspectUse;
    public EventHandler OnInspectCanceled;

    protected EquippableItemState currentItemState;
    protected EquippableItemHolsterType currentHolsterType;
    protected Transform currentHolsterTransform;

    protected InventoryItem inventoryItem;
    protected PlayerInputHandler playerInputHandler;
    
    protected Transform activeHolsterTransform;
    protected Transform defaultHolsterTransform;

    protected ChildBehaviour activeTransformChildBehaviour;

    protected Transform cameraTransform;

    private IEnumerator currentHolsterAnimation;

    private void OnDestroy() {
        StopAllCoroutines();
        UnsubscribeFromInputEvents();
    }

    public virtual void SaveData(){
        
    }

    public virtual void SetupItemBehaviour(InventoryItem _inventoryItem, PlayerInputHandler _playerInputHandler){
        cameraTransform = Camera.main.transform; //TO-DO: Refactor to not grab the main camera everytime. Might not be a big deal but could cause potential issues later
        inventoryItem = _inventoryItem;
        playerInputHandler = _playerInputHandler;
    }

    public void SetupPlayerItemHolster(Transform _defaultHolsterTransform, Transform _activeHolsterTransform){
        defaultHolsterTransform = _defaultHolsterTransform;
        activeHolsterTransform = _activeHolsterTransform;
    
        if(!activeHolsterTransform.TryGetComponent(out activeTransformChildBehaviour)){
            Debug.LogError("No child behaviour found on: " + activeHolsterTransform.name + ". Weapon state animations will not be applied correctly.");
        }
    }

    public virtual void WeaponUseInput(object sender, InputEventArgs e){
        
    }

    public virtual void WeaponAltUseInput(object sender, InputEventArgs e){
        
    }

    public virtual void EmergencyItemUseInput(object sender, InputEventArgs e){
       
    }

    public virtual void HolsterWeaponInput(object sender, InputEventArgs e){
        if(e.inputActionPhase != UnityEngine.InputSystem.InputActionPhase.Performed || currentHolsterAnimation != null) return;
        switch (currentItemState){
            case EquippableItemState.Active: 
                ChangeItemState(EquippableItemState.Holstered);
                ChangeWeaponState(WeaponState.Default);
                OnHolsterWeapon?.Invoke(this, EventArgs.Empty);
                break;
            case EquippableItemState.Holstered: 
                ChangeItemState(EquippableItemState.Active);
                OnUnholsterWeapon?.Invoke(this, EventArgs.Empty);
                break;
        }
    }

    public virtual void ReloadInput(object sender, InputEventArgs e){
        
    }

    public virtual void InspectInput(object sender, InputEventArgs e){
        
    }

    public virtual void UpdateControlOnItemStateChange(){
        switch (currentItemState){
            case EquippableItemState.Active: SubscribeToInputEvents();
                break;
            case EquippableItemState.Holstered: UnsubscribeFromInputEvents();
                break;
            case EquippableItemState.Used: UnsubscribeFromInputEvents();
                break;
            case EquippableItemState.Passive: SubscribeToInputEvents();
                break;
        }
    }

    protected virtual void SubscribeToInputEvents(){

    }

    protected virtual void UnsubscribeFromInputEvents(){

    }

    public void TriggerDefaultState(){
        currentItemState = defaultItemState;
        ChangeItemHolster(defaultHolsterTransform, true);
        UpdateControlOnItemStateChange();
    }

    public void ChangeItemState(EquippableItemState newState){
        if(newState == currentItemState) return;

        currentItemState = newState;

        switch (newState){
            case EquippableItemState.None: ChangeItemHolster(null);
                break;
            case EquippableItemState.Active: ChangeItemHolster(activeHolsterTransform);
                break;
            case EquippableItemState.Holstered: ChangeItemHolster(defaultHolsterTransform);
                break;
            case EquippableItemState.Used: ChangeItemHolster(null);
                break;
            case EquippableItemState.Passive: ChangeItemHolster(defaultHolsterTransform);
                break;
        }

        UpdateControlOnItemStateChange();
    }

    protected virtual void ChangeWeaponState(WeaponState newState){
        if(newState == currentWeaponState) return;

        OnWeaponStateChanged?.Invoke(this, new WeaponStateChangedEventArgs(newState));

        currentWeaponState = newState;
        UpdateChildBehaviourData();
    }

    protected virtual void UpdateChildBehaviourData(){
        if(activeTransformChildBehaviour == null) return;

        switch (currentWeaponState){
            case WeaponState.Default: activeTransformChildBehaviour.ResetChildBehaviourData();
                break;
            case WeaponState.Aiming: activeTransformChildBehaviour.SetChildBehaviourData(aimedChildData);
                break;
            case WeaponState.Inspecting: activeTransformChildBehaviour.SetChildBehaviourData(inspectingChildData);
                break;
            case WeaponState.Reloading: activeTransformChildBehaviour.SetChildBehaviourData(reloadingChildData);
                break;
        }
    }

    public EquippableItemHolsterType GetPlayerItemHolsterType(){
        return defaultItemHolsterType;
    }

    public EquippableItemState GetPlayerItemState(){
        return defaultItemState;      
    }

    public WeaponState GetWeaponState(){
        return currentWeaponState;
    }

    public virtual ResourceDataSO GetEquippedItemResourceData(){
        return null;
    }

    public virtual WeaponDataSO GetEquippedWeaponData(){
        return null;
    }

    private void ChangeItemHolster(Transform holsterTransform, bool spawnHolster = false){
        currentHolsterTransform = holsterTransform;

        if(holsterTransform == null) return;

        StopCurrentHolsterAnimation();

        if(playHolsterAnimation && !spawnHolster){            
            currentHolsterAnimation = HolsterAnimationCoroutine(holsterTransform);
            StartCoroutine(currentHolsterAnimation);
        }
        else{
            transform.parent = currentHolsterTransform;
            transform.SetPositionAndRotation(currentHolsterTransform.position, currentHolsterTransform.rotation);
        }
    }

    private void StopCurrentHolsterAnimation(){
        if(currentHolsterAnimation != null){
            StopCoroutine(currentHolsterAnimation);
            currentHolsterAnimation = null;
        }
    }

    private IEnumerator HolsterAnimationCoroutine(Transform holsterTransform){
        transform.parent = null;
        float elapsedTime = 0f;
        
        while(elapsedTime < holsterAnimationDuration){
            elapsedTime += Time.deltaTime;

            float t = Mathf.Clamp01(elapsedTime / holsterAnimationDuration);

            transform.SetPositionAndRotation(Vector3.Lerp(transform.position, holsterTransform.position, t), Quaternion.Slerp(transform.rotation, holsterTransform.rotation, t));
            yield return null;
        }

        transform.SetPositionAndRotation(holsterTransform.position, holsterTransform.rotation);
        transform.parent = currentHolsterTransform;

        currentHolsterAnimation = null;
    }
}
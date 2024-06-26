using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LighterBehaviour : EquippedItemBehaviour{
    [Header("Required Reference")]
    [SerializeField] private Light lightReference;
    [SerializeField] private Vector3 holdOutPosition;

    public override void SetupItemBehaviour(InventoryItem _inventoryItem, PlayerInputHandler _playerInputHandler){
        base.SetupItemBehaviour(_inventoryItem, _playerInputHandler);
        lightReference.enabled = true;
    }

    protected override void SubscribeToInputEvents(){
        playerInputHandler.OnEmergencyItemUse += EmergencyItemUseInput;
        playerInputHandler.OnWeaponUse += WeaponUseInput;
        playerInputHandler.OnAltWeaponUse += WeaponAltUseInput;
        playerInputHandler.OnHolsterWeapon += HolsterWeaponInput;
    }

    protected override void UnsubscribeFromInputEvents(){
        playerInputHandler.OnEmergencyItemUse -= EmergencyItemUseInput;
        playerInputHandler.OnWeaponUse -= WeaponUseInput;
        playerInputHandler.OnAltWeaponUse -= WeaponAltUseInput;
        playerInputHandler.OnHolsterWeapon -= HolsterWeaponInput;
    }

    public override void EmergencyItemUseInput(object sender, InputEventArgs e){

    }

    public override void WeaponUseInput(object sender, InputEventArgs e){

    }

    public override void WeaponAltUseInput(object sender, InputEventArgs e){

    }

    public override void HolsterWeaponInput(object sender, InputEventArgs e){
        base.HolsterWeaponInput(sender, e);
    }
}

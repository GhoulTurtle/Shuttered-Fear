using UnityEngine;

/// <summary>
/// Base scriptable object that all items derive from. Holds needed variables and methods for items.
/// </summary>

[CreateAssetMenu(menuName = "Item/Basic Item", fileName = "NewItemDataSO")]
public class ItemDataSO : ScriptableObject{
    [Header("Item Information")]
    [SerializeField] private string itemName;
    [SerializeField] private string itemQuickDescription;
    [SerializeField, TextArea(3,3)] private string itemInspectDescription;
    
    [Header("Item Visual")]
    [SerializeField] private Sprite itemIcon;
    [SerializeField] private Transform itemInventoryModelPrefab;
    [SerializeField] private Transform itemInWorldModelPrefab;

    [Header("Item Settings")]
    [SerializeField] private ItemType itemType;
    [SerializeField] private bool isUseable = true;
    [SerializeField] private bool isCombinable = false;
    [SerializeField] private bool isStackable = true;
    [SerializeField] private bool isDestroyable = true;
    [SerializeField] private int maxStackSize = 1;

    public string GetItemName(){
        return itemName;
    }

    public string GetItemQuickDescription(){
        return itemQuickDescription;
    }

    public string GetItemInspectDescription(){
        return itemInspectDescription;
    }

    public Sprite GetItemSprite(){
        return itemIcon;
    }

    public Transform GetItemInventoryModel(){
        return itemInventoryModelPrefab;
    }

    public Transform GetItemInWorldModel(){
        return itemInWorldModelPrefab;
    }

    public ItemType GetItemType(){
        return itemType;
    }

    public bool GetIsUseable(){
        return isUseable;
    }

    public bool GetIsCombinable(){
        return isCombinable;
    }

    public bool GetIsStackable(){
        return isStackable;
    }

    public bool GetIsDestroyable(){
        return isDestroyable;
    }

    public int GetItemMaxStackSize(){
        return maxStackSize;
    }

    public virtual bool UseItem(){return true;}
}
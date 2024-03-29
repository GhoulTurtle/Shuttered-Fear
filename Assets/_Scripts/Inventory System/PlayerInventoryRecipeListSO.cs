using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A scriptable object responsible for managing a list of inventory recipes for the player. Can add new recipes and trigger callbacks when new recipes are added. 
/// </summary>

[CreateAssetMenu(menuName = "Inventory/Player Recipe List", fileName = "NewPlayerRecipeListSO")]
public class PlayerInventoryRecipeListSO : ScriptableObject{
    [Header("Known Recipe List")]
    [SerializeField] private List<InventoryRecipeSO> knownInventoryRecipes;

    public EventHandler<NewRecipeAddedEventArgs> OnNewRecipeAdded;
    public class NewRecipeAddedEventArgs : EventArgs{
        public InventoryRecipeSO newRecipeAdded;
        public NewRecipeAddedEventArgs(InventoryRecipeSO _newRecipeAdded){
            newRecipeAdded = _newRecipeAdded;
        }
    }

    #if UNITY_EDITOR
    [Header("Recipe Editor Variables")]
    [SerializeField] private bool defaultRecipeOnPlay = false;
    [SerializeField] private List<InventoryRecipeSO> defaultInventoryRecipes;
    #endif

    #if UNITY_EDITOR
    public void OnEnable(){
        if(defaultRecipeOnPlay){
            knownInventoryRecipes = defaultInventoryRecipes;
        }
    }
    #endif

    public void AddInventoryRecipe(InventoryRecipeSO inventoryRecipe){
        if(knownInventoryRecipes.Contains(inventoryRecipe)) return;

        knownInventoryRecipes.Add(inventoryRecipe);
        OnNewRecipeAdded?.Invoke(this, new NewRecipeAddedEventArgs(inventoryRecipe));
    }

    public void RemoveInventoryRecipe(InventoryRecipeSO inventoryRecipe){
        if(!knownInventoryRecipes.Contains(inventoryRecipe)) return;
        
        knownInventoryRecipes.Remove(inventoryRecipe);
    }

    public InventoryItem ReturnValidInventoryRecipeResult(ItemDataSO firstItem, ItemDataSO secondItem){
        if(firstItem == null || secondItem == null) return null;

        InventoryRecipeSO validRecipe = null;
        foreach (InventoryRecipeSO itemRecipe in knownInventoryRecipes){
            if(itemRecipe.ReturnIsValidCombination(firstItem, secondItem)){
                validRecipe = itemRecipe;
                break;
            }
        }
        
        if(validRecipe == null) return null;

        return new InventoryItem(validRecipe.GetResultItemData(), validRecipe.GetResultItemStackAmount());
    }
}
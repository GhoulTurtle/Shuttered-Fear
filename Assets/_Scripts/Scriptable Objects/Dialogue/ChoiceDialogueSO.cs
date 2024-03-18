using UnityEngine;

[CreateAssetMenu(menuName = "Dialogue/Choice Dialogue", fileName = "NewChoiceDialogue")]
public class ChoiceDialogueSO : ScriptableObject{
    [Header("Choice Dialogue Variables")]
    public bool isCancelable = false;
    public Dialogue Question;
    public ChoiceDialogue[] Choices;
}
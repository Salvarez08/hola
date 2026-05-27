using UnityEngine;

[CreateAssetMenu(
    fileName = "New Visual Novel Node",
    menuName = "Visual Novel/Node"
)]
public class VisualNovelNodeSO : ScriptableObject
{
    [Header("Texto de la escena")]
    [TextArea(3, 8)]
    public string sceneText;

    [Header("Botones")]
    [Range(0, 4)]
    public int buttonAmount;

    public string[] buttonNames = new string[4];

    [Header("Personaje 1")]
    public bool activateCharacterOne;

    [Header("Personaje 2")]
    public bool activateCharacterTwo;

    public string nodeName;
    [TextArea] public string descriptionText;

    // Array to hold the next possible ScriptableObjects (up to 3 for your branching choices)
    public VisualNovelNodeSO[] nextChoices;
}

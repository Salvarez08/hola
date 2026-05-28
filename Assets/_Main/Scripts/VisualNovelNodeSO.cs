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
    [Range(0, 3)]
    public int buttonAmount;

    public string[] buttonNames = new string[3];

    [Header("Estados destino de cada botón")]
    public StoryState[] nextStates = new StoryState[3];

    [Header("Background")]
    public bool changeBackground;
    public int backgroundSpriteIndex;


    [Header("Personaje 1")]
    public bool activateCharacterOne;
    public int characterOneMainSpriteIndex;
    

    [Header("Personaje 2")]
    public bool activateCharacterTwo;
    public int characterTwoMainSpriteIndex;
   
}
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
    public int characterOneHairSpriteIndex;
    public int characterOneWhiteSpriteIndex;
    public int characterOneTearSpriteIndex;
    public int characterOneMouthSpriteIndex;
    public int characterOneGraphicSpriteIndex;
    public int characterOneEyelibsSpriteIndex;
    public int characterOnePupilSpriteIndex;
    public int characterOneEyebrowsSpriteIndex;
    public int characterOneCheekSpriteIndex;

    [Header("Personaje 2")]
    public bool activateCharacterTwo;
    public int characterTwoMainSpriteIndex;
    public int characterTwoHairSpriteIndex;
    public int characterTwoWhiteSpriteIndex;
    public int characterTwoTearSpriteIndex;
    public int characterTwoMouthSpriteIndex;
    public int characterTwoGraphicSpriteIndex;
    public int characterTwoEyelibsSpriteIndex;
    public int characterTwoPupilSpriteIndex;
    public int characterTwoEyebrowsSpriteIndex;
    public int characterTwoCheekSpriteIndex;
}
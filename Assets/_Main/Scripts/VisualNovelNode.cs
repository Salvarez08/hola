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

    [Header("Personaje 1")]
    public bool activateCharacterOne;

    [Header("Personaje 2")]
    public bool activateCharacterTwo;
}

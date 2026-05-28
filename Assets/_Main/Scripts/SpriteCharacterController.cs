using UnityEngine;

public class SpriteCharacterController : MonoBehaviour
{
    [Header("Índices actuales")]
    public int mainSpriteIndex;
    public int hairSpriteIndex;
    public int whiteSpriteIndex;
    public int tearSpriteIndex;
    public int mouthSpriteIndex;
    public int graphicSpriteIndex;
    public int eyelibsSpriteIndex;
    public int pupilSpriteIndex;
    public int eyebrowsSpriteIndex;
    public int cheekSpriteIndex;

    [Header("Array SpriteRenderer")]
    public SpriteRenderer[] spriteRenderers;

    [Header("Array Sprite")]
    public Sprite[] mainSprites;
    public Sprite[] hairSprites;
    public Sprite[] whiteSprites;
    public Sprite[] tearSprites;
    public Sprite[] mouthSprites;
    public Sprite[] graphicSprites;
    public Sprite[] eyelibsSprites;
    public Sprite[] pupilSprites;
    public Sprite[] eyebrowsSprites;
    public Sprite[] cheekSprites;

    private void Update()
    {
        spriteRenderers[0].sprite = mainSprites[mainSpriteIndex];
        spriteRenderers[1].sprite = hairSprites[hairSpriteIndex];
        spriteRenderers[2].sprite = whiteSprites[whiteSpriteIndex];
        spriteRenderers[3].sprite = mouthSprites[mouthSpriteIndex];
        spriteRenderers[4].sprite = graphicSprites[graphicSpriteIndex];
        spriteRenderers[5].sprite = eyelibsSprites[eyelibsSpriteIndex];
        spriteRenderers[6].sprite = pupilSprites[pupilSpriteIndex];
        spriteRenderers[7].sprite = eyebrowsSprites[eyebrowsSpriteIndex];
        spriteRenderers[8].sprite = cheekSprites[cheekSpriteIndex];
        spriteRenderers[9].sprite = tearSprites[tearSpriteIndex];
    }
}
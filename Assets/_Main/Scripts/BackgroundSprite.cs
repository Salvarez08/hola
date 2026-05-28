using UnityEngine;

public class BackgroundSprite: MonoBehaviour
{
    [Header("Índices actuales")]
    public int backgroundSpriteIndex;

    [Header("Array SpriteRenderer")]
    public SpriteRenderer[] spriteRenderers;

    [Header("Array Sprite")]
    public Sprite[] backgroundSprite;

    private void Update()
    {
        spriteRenderers[0].sprite = backgroundSprite[backgroundSpriteIndex];
    }
}

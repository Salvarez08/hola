using UnityEngine;

public class SpriteCharacterController : MonoBehaviour
{
    [Header("Índices actuales")]
    public int mainSpriteIndex;
  

    [Header("Array SpriteRenderer")]
    public SpriteRenderer[] spriteRenderers;

    [Header("Array Sprite")]
    public Sprite[] mainSprites;
    

    private void Update()
    {
        spriteRenderers[0].sprite = mainSprites[mainSpriteIndex];
      
    }
}
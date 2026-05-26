using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    //index 

    [SerializeField]
    private int _spriteRendererIndex;

    [SerializeField]
    private int _irisRendererIndex;

    [SerializeField]
    private int _mouthRenderIndex;

    [SerializeField]
    private int _hairRenderIndex;

    [SerializeField]
    private int _eyebrowRenderIndex;

    [SerializeField]
    private int _TearsRenderIndex;

    [SerializeField]
    private int _eyelidsRenderIndex;

    [SerializeField]
    private int _whiteRenderIndex;

    [SerializeField]
    private int _cheekRenderIndex;


    [Header("Sprite")]

    [SerializeField]
    private Sprite _mainSprite;



    [SerializeField]
    private Sprite _hairSprite;


    [SerializeField]
    private Sprite _whiteSprite;



    [Header("array sprite renderer")]

    [SerializeField]
    private SpriteRenderer[] _sprite_rendererds;

    [Header("Array sprites")]

    [SerializeField]
    private Sprite[] _sprite;




    [Header("Array sprite")]


    [SerializeField]
    private Sprite[] _tearSprites;

    [SerializeField]
    private Sprite[] _mouthSprites;

    [SerializeField]
    private Sprite[] _cheekSprites;

    [SerializeField]
    private Sprite[] _eyebrowSprites;

    [SerializeField]
    private Sprite[] _eyelidSprites;

    [SerializeField]
    private Sprite[] _irisSprites;

    private void Start()
    {


    }



    private void Update()
    {
        _sprite_rendererds[8].sprite = _irisSprites[_irisRendererIndex];


        _sprite_rendererds[0].sprite = _mouthSprites[_mouthRenderIndex];


        _sprite_rendererds[3].sprite = _tearSprites[_TearsRenderIndex];


        _sprite_rendererds[5].sprite = _cheekSprites[_cheekRenderIndex];


        _sprite_rendererds[4].sprite = _eyebrowSprites[_eyebrowRenderIndex];


        _sprite_rendererds[6].sprite = _eyelidSprites[_eyelidsRenderIndex];
    }
}

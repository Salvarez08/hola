using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class UIManagerScriot : MonoBehaviour
{


    // Call this method from your Button's OnClick event
    public void ChangeSO(VisualNovelNodeSO newData)
    {
        _currentNode = newData;
        Debug.Log("Swapped to: " + _currentNode.name);

        // Update your UI or game logic here to reflect the new data
    }

    [SerializeField] 
    private GameObject _paneldialogo;
    [SerializeField]
    private TMP_Text _textodialogo;
    [SerializeField]
    private VisualNovelNodeSO _currentNode;

    [Header("Buttons")]
    [SerializeField]
    private Button _boton1;
    [SerializeField]
    private Button _boton2;
    [SerializeField]
    private Button _boton3;

    [Header("Buttons")]
    [SerializeField]
    private TMP_Text[] _textbutton;
    private void Start()
    {
        //Cantidad botones
        _boton1.gameObject.SetActive(_currentNode.buttonAmount > 0);
        _boton2.gameObject.SetActive(_currentNode.buttonAmount > 1);
        _boton3.gameObject.SetActive(_currentNode.buttonAmount > 2);

        //texto dialogo y botones
        _textodialogo.text = _currentNode.sceneText; 
        _textbutton[0].text = _currentNode.buttonNames[0];
        _textbutton[1].text = _currentNode.buttonNames[1];
        _textbutton[2].text = _currentNode.buttonNames[2];
    }
    private void Update()
    {
        //Cantidad botones
        _boton1.gameObject.SetActive(_currentNode.buttonAmount > 0);
        _boton2.gameObject.SetActive(_currentNode.buttonAmount > 1);
        _boton3.gameObject.SetActive(_currentNode.buttonAmount > 2);

        //texto dialogo y botones
        _textodialogo.text = _currentNode.sceneText;
        _textbutton[0].text = _currentNode.buttonNames[0];
        _textbutton[1].text = _currentNode.buttonNames[1];
        _textbutton[2].text = _currentNode.buttonNames[2];
    }
}

using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class UIManagerScriot : MonoBehaviour
{

    // Drag your ScriptableObjects here in the exact order you want them to appear
    [SerializeField] private VisualNovelNodeSO[] dataSequence;

    private int currentIndex = 0;

    // Track the active asset
    public VisualNovelNodeSO _currentNode;   


    [SerializeField] 
    private GameObject _paneldialogo;
    [SerializeField]
    private TMP_Text _textodialogo;


    [Header("Buttons")]
    [SerializeField]
    private Button _next;
    [SerializeField]
    private Button _boton1;
    [SerializeField]
    private Button _boton2;
    [SerializeField]
    private Button _boton3;
    
   

    [Header("Buttons")]
    [SerializeField]
    private TMP_Text[] _textbutton;

    public void AdvanceToNextSO()
    {
        if (dataSequence.Length == 0) return;

        // Move to the next index, resetting to 0 if we hit the end
        currentIndex = (currentIndex + 1) % dataSequence.Length;

        _currentNode = dataSequence[currentIndex];
        

        // Trigger any UI or game updates here
    }
    private void Start()
    {

        // Set the initial item if the array is populated
        if (dataSequence.Length > 0)
        {
            _currentNode = dataSequence[0];
        }

        //Cantidad botones
        _next.gameObject.SetActive(_currentNode.buttonAmount > 0);
        _boton1.gameObject.SetActive(_currentNode.buttonAmount > 1);
        _boton2.gameObject.SetActive(_currentNode.buttonAmount > 2);
        _boton3.gameObject.SetActive(_currentNode.buttonAmount > 3);
       

        //texto dialogo y botones
        _textodialogo.text = _currentNode.sceneText; 
        _textbutton[0].text = _currentNode.buttonNames[0];
        _textbutton[1].text = _currentNode.buttonNames[1];
        _textbutton[2].text = _currentNode.buttonNames[2];
        _textbutton[3].text = _currentNode.buttonNames[3];
        
      
    }
    private void Update()
    {
        //Cantidad botones
        _next.gameObject.SetActive(_currentNode.buttonAmount > 0);
        _boton1.gameObject.SetActive(_currentNode.buttonAmount > 1);
        _boton2.gameObject.SetActive(_currentNode.buttonAmount > 2);
        _boton3.gameObject.SetActive(_currentNode.buttonAmount > 3);


        //texto dialogo y botones
        _textodialogo.text = _currentNode.sceneText;
        _textbutton[0].text = _currentNode.buttonNames[0];
        _textbutton[1].text = _currentNode.buttonNames[1];
        _textbutton[2].text = _currentNode.buttonNames[2];
        _textbutton[3].text = _currentNode.buttonNames[3];
    }
}

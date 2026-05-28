using UnityEngine;

public enum StoryState
{
    Inicio,
    Detonante,
    Correr1,
    Correr2,
    Correr3,
    Besarla1,
    Besarla2,
    Besarla3,
    Patearla1,
    Patearla2,
    Patearla3,
    Final,

}
public class GameManager : MonoBehaviour
{
    [Header("UI Manager")]
    [SerializeField]
    private UIManager _uiManager;

    [Header("Estado actual")]
    [SerializeField]
    private StoryState _currentState;

    [Header("Nodo actual")]
    [SerializeField]
    private VisualNovelNodeSO _currentNode;

    [Header("Nodos de historia")]
    [SerializeField]
    private VisualNovelNodeSO _inicioNode;

    [SerializeField]
    private VisualNovelNodeSO _detonanteNode;

    [SerializeField]
    private VisualNovelNodeSO _correr1Node;

    [SerializeField]
    private VisualNovelNodeSO _correr2Node;

    [SerializeField]
    private VisualNovelNodeSO _correr3Node;

    [SerializeField]
    private VisualNovelNodeSO _besarla1Node;

    [SerializeField]
    private VisualNovelNodeSO _besarla2Node;

    [SerializeField]
    private VisualNovelNodeSO _besarla3Node;

    [SerializeField]
    private VisualNovelNodeSO _patearla1Node;

    [SerializeField]
    private VisualNovelNodeSO _patearla2Node;

    [SerializeField]
    private VisualNovelNodeSO _patearla3Node;

    [SerializeField]
    private VisualNovelNodeSO _finalNode;


    [Header("Personaje 1")]
    [SerializeField]
    private GameObject _characterOneGameObject;

    [SerializeField]
    private SpriteCharacterController _characterOneController;

    [Header("Personaje 2")]
    [SerializeField]
    private GameObject _characterTwoGameObject;

    [SerializeField]
    private SpriteCharacterController _characterTwoController;

    private void Start()
    {
        ChangeState(_currentState);
    }

    public void SelectOption(int buttonIndex)
    {
        StoryState nextState = _currentNode.nextStates[buttonIndex];

        ChangeState(nextState);
    }

    public void ChangeState(StoryState newState)
    {
        _currentState = newState;

        switch (_currentState)
        {
            case StoryState.Inicio:
                _currentNode = _inicioNode;
                break;

            case StoryState.Detonante:
                _currentNode = _detonanteNode;
                break;
            case StoryState.Correr1:
                _currentNode = _correr1Node;
                break;
            case StoryState.Correr2:
                _currentNode = _correr2Node;
                break;
            case StoryState.Correr3:
                _currentNode = _correr3Node;
                break;
            case StoryState.Besarla1:
                _currentNode = _besarla1Node;
                break;
            case StoryState.Besarla2:
                _currentNode = _besarla2Node;
                break;
            case StoryState.Besarla3:
                _currentNode = _besarla3Node;
                break;
            case StoryState.Patearla1:
                _currentNode = _patearla1Node;
                break;
            case StoryState.Patearla2:
                _currentNode = _patearla2Node;
                break;
            case StoryState.Patearla3:
                _currentNode = _patearla3Node;
                break;
            case StoryState.Final:
                _currentNode = _finalNode;
                break;

        }

        if (_currentNode == null)
        {
            Debug.LogWarning("No hay un nodo asignado para este estado.");
            return;
        }

        _uiManager.ConfigureUI(_currentNode);

        _characterOneGameObject.SetActive(_currentNode.activateCharacterOne);

        if (_currentNode.activateCharacterOne)
        {
            _characterOneController.mainSpriteIndex = _currentNode.characterOneMainSpriteIndex;
            _characterOneController.hairSpriteIndex = _currentNode.characterOneHairSpriteIndex;
            _characterOneController.whiteSpriteIndex = _currentNode.characterOneWhiteSpriteIndex;
            _characterOneController.tearSpriteIndex = _currentNode.characterOneTearSpriteIndex;
            _characterOneController.mouthSpriteIndex = _currentNode.characterOneMouthSpriteIndex;
            _characterOneController.graphicSpriteIndex = _currentNode.characterOneGraphicSpriteIndex;
            _characterOneController.eyelibsSpriteIndex = _currentNode.characterOneEyelibsSpriteIndex;
            _characterOneController.pupilSpriteIndex = _currentNode.characterOnePupilSpriteIndex;
            _characterOneController.eyebrowsSpriteIndex = _currentNode.characterOneEyebrowsSpriteIndex;
            _characterOneController.cheekSpriteIndex = _currentNode.characterOneCheekSpriteIndex;
        }

        _characterTwoGameObject.SetActive(_currentNode.activateCharacterTwo);

        if (_currentNode.activateCharacterTwo)
        {
            _characterTwoController.mainSpriteIndex = _currentNode.characterTwoMainSpriteIndex;
            _characterTwoController.hairSpriteIndex = _currentNode.characterTwoHairSpriteIndex;
            _characterTwoController.whiteSpriteIndex = _currentNode.characterTwoWhiteSpriteIndex;
            _characterTwoController.tearSpriteIndex = _currentNode.characterTwoTearSpriteIndex;
            _characterTwoController.mouthSpriteIndex = _currentNode.characterTwoMouthSpriteIndex;
            _characterTwoController.graphicSpriteIndex = _currentNode.characterTwoGraphicSpriteIndex;
            _characterTwoController.eyelibsSpriteIndex = _currentNode.characterTwoEyelibsSpriteIndex;
            _characterTwoController.pupilSpriteIndex = _currentNode.characterTwoPupilSpriteIndex;
            _characterTwoController.eyebrowsSpriteIndex = _currentNode.characterTwoEyebrowsSpriteIndex;
            _characterTwoController.cheekSpriteIndex = _currentNode.characterTwoCheekSpriteIndex;
        }
    }
}

using UnityEngine;

public enum StoryState
{
    Inicio,
    Detonante1,
    Detonante2,
    Resolucion,
    Final,
    Conclusion
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
    private VisualNovelNodeSO _detonante1Node;
    [SerializeField]
    private VisualNovelNodeSO _detonante2Node;

    [SerializeField]
    private VisualNovelNodeSO _resolucionNode;

    [SerializeField]
    private VisualNovelNodeSO _finalNode;

    [SerializeField]
    private VisualNovelNodeSO _conclusionNode;

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

            case StoryState.Detonante1:
                _currentNode = _detonante1Node;
                break;

            case StoryState.Detonante2:
                _currentNode = _detonante2Node;
                break;

            case StoryState.Resolucion:
                _currentNode = _resolucionNode;
                break;

            case StoryState.Final:
                _currentNode = _finalNode;
                break;

            case StoryState.Conclusion:
                _currentNode = _conclusionNode;
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

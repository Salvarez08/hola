using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [Header("Game Manager")]
    [SerializeField]
    private GameManager _gameManager;

    [Header("Panel de diálogo")]
    [SerializeField]
    private GameObject _panelDialogo;

    [SerializeField]
    private TMP_Text _textDialogo;

    [Header("Botones")]
    [SerializeField]
    private Button[] _buttons;

    [Header("Textos de los botones")]
    [SerializeField]
    private TMP_Text[] _textButton;

    public void ConfigureUI(VisualNovelNodeSO node)
    {
        _panelDialogo.SetActive(true);
        _textDialogo.text = node.sceneText;

        for (int i = 0; i < _buttons.Length; i++)
        {
            bool shouldShowButton = i < node.buttonAmount;

            _buttons[i].gameObject.SetActive(shouldShowButton);

            if (shouldShowButton)
            {
                _textButton[i].text = node.buttonNames[i];

                int buttonIndex = i;

                _buttons[i].onClick.RemoveAllListeners();

                _buttons[i].onClick.AddListener(() =>
                {
                    _gameManager.SelectOption(buttonIndex);
                });
            }
        }
    }
}
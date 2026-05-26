using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class UIManagerScriot : MonoBehaviour
{
  [SerializeField] 
    private GameObject _paneldialogo;
    [SerializeField]
    private TMP_Text _textodialogo;

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
      _textodialogo.text = "Estás caminando tranquilamente por la universidad, pensando en que harás en la tarde en vez de los trabajos que son para la otra semana, cuando de repente,te encuentras con tu crush,  ¿Qué vas a hacer?";
        _textbutton[0].text = "Correr";
        _textbutton[1].text = "Besarla";
        _textbutton[2].text = "Patearla";
    }
}

using JetBrains.Annotations;
using TMPro;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public int entero;
    public TMP_Text textoresultado;
    void Start()
    {
        entero = 0;
        EstadosJuego(entero);
        
    }


    void Update()
    {
        
    }

    public void EstadosJuego(int numero)
    {
       
        switch(numero)
        {
            case 0:
                textoresultado.text = ("Estás caminando tranquilamente por la universidad, pensando en que harás en la tarde en vez de los trabajos que son para la otra semana, cuando de repente,te encuentras con tu crush,  ¿Qué vas a hacer?");
                break;
            case 1:
            textoresultado.text = ("El pánico es demasiado para ti, decides que la única opción razonable es salir corriendo. Lamentablemente, el mismo panico que te dio velocidad supersonica hizo que olvidaras voltear antes de correr, esperemos que tu crush pueda resistir un impacto a velocidad Mach 3.");
                break;
            case 2:
                textoresultado.text = ("Has jugado tantas novelas visuales que no sabes como interactuar con mujeres en la vida real, y piensas que es normal e incluso muy rómantico besar a alguien con quien has hablado 3 veces, te acercas a ella y te preparas para besarla, pero tu crush se percata de tus intenciones, y antes de que puedas ganarte una denuncia en fiscalía, te hace una llave de jiu-jitsu y te manda al suelo. Ouch, hasta yo sentí el golpe en tus costillas, pero lo merecías.");
                break;
            case 3:
                textoresultado.text = ("Al ver a tu crush, haces lo que haría cualquier humano racional; recuerdas las enseñanzas de tu sensei, te paras sobre una sola pierna y preparas todo el peso de tu cuerpo para lanzar un ataque devastador capaz de derrumbar árboles. Tu movimiento es veloz e imperceptible para un humano normal, pero no para tu crush, que logra bloquearlo con un solo dedo, en ese instante recuerdas por qué te enamoraste de ella.");
                break;
            default:
                textoresultado.text = ("Opción invalida");
                break;
        }
    }
}

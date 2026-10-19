using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
// Suggestion: este script hace lo mismo que Menu.Play(), y entre Quit.cs, Exitgame.cs, Menu.Exit y Pausemenu.Exit hay cuatro formas distintas de cerrar el juego.
// Dejá una sola de cada cosa.
public class Playbutton : MonoBehaviour
{
    public GameObject Mainmenu;

    public void Play()
    {
        Mainmenu.SetActive(false);
        SceneManager.LoadScene("Game");
    }
}
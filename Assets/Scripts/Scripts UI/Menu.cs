using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject Mainmenu;
    public GameObject settingsPanel;
    public GameObject creditsPanel;

    public void Play()
    {
        // Suggestion: "Game" escrito a mano acá y en Playbutton.cs:11. Si renombrás la escena, el proyecto compila igual y falla recién en runtime.
        // Declaralo como const string en una clase compartida.
        SceneManager.LoadScene("Game");
    }

    public void Settings()
    {
        Mainmenu.SetActive(false);
        settingsPanel.SetActive(true);
    }

    public void Credits()
    {
        Mainmenu.SetActive(false);
        creditsPanel.SetActive(true);
    }

    public void Back()
    {
        settingsPanel.SetActive(false);
        creditsPanel.SetActive(false);
        Mainmenu.SetActive(true);
    }

    public void Exit()
    {
        Application.Quit();
    }
}

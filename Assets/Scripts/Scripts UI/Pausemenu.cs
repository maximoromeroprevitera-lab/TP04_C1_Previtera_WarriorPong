using UnityEngine;
public class Pausemenu : MonoBehaviour
{
    public GameObject Pausepanel;
    public GameObject Settingspanel;
    public GameObject Creditspanel;

    public GameObject ScorePlayer1;
    public GameObject ScorePlayer2;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
    }
    public void Pause()
    {
        Pausepanel.SetActive(true);
        ScorePlayer1.SetActive(false);
        ScorePlayer2.SetActive(false);

        Time.timeScale = 0;
    }
    public void Continue()
    {
        Pausepanel.SetActive(false);
        Settingspanel.SetActive(false);
        Creditspanel.SetActive(false);

        ScorePlayer1.SetActive(true);
        ScorePlayer2.SetActive(true);

        Time.timeScale = 1;
    }

    public void Settings()
    {
        Pausepanel.SetActive(false);
        Settingspanel.SetActive(true);
    }
    public void Credits()
    {
        Pausepanel.SetActive(false);
        Creditspanel.SetActive(true);
    }
    public void Exit()
    {
        Time.timeScale = 1;
        Application.Quit();
    }
}
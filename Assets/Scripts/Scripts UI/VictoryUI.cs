using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class VictoryUI : MonoBehaviour
{
    // Textos donde se muestran los puntos
    public TMP_Text scorePlayer1;
    public TMP_Text scorePlayer2;

    // Panel que aparece cuando alguien gana
    public GameObject VictoryPanel;

    // Texto que muestra quién ganó
    public TMP_Text winnerText;

    private void Start()
    {
        // Al comenzar la partida, el panel de victoria está oculto
        VictoryPanel.SetActive(false);

        // Los puntajes empiezan en 0
        UpdateScore(0, 0);
    }

    // Actualiza los dos puntajes de la pantalla
    public void UpdateScore(int player1Score, int player2Score)
    {
        scorePlayer1.text = player1Score.ToString();
        scorePlayer2.text = player2Score.ToString();
    }

    // Muestra el panel cuando termina la partida
    public void ShowWinner(string winner)
    {
        winnerText.text = winner + " GANA!";

        VictoryPanel.SetActive(true);

        // Detiene todo el juego
        Time.timeScale = 0f;
    }

    // Botón "Jugar de nuevo"
    public void PlayAgain()
    {
        // Primero volvemos a poner el tiempo normal
        Time.timeScale = 1f;

        // Recarga la escena Game desde cero
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Botón "Salir"
    public void ExitGame()
    {
        // Por seguridad, restauramos el tiempo
        Time.timeScale = 1f;

        Application.Quit();
    }
}
using UnityEngine;
public class GoalManager : MonoBehaviour
{
    public int player1Wins = 0;
    public int player2Wins = 0;
    public GameSettings gameSettings;
    public GameObject ballPrefab;
    public Transform ballSpawnPoint;
    // Referencia a la UI
    public VictoryUI gameUI;
    public void Player1Goal()
    {
        player1Wins++;

        Debug.Log("Player 1 anotó! Puntos: " + player1Wins);

        // Actualizamos el marcador
        if (gameUI != null)
        {
            gameUI.UpdateScore(player1Wins, player2Wins);
        }

        // Si todavía no ganó, creamos una nueva pelota
        if (gameSettings != null)
        {
            if (player1Wins >= gameSettings.winsToWin)
            {
                Debug.Log("¡PLAYER 1 GANÓ!");

                // Mostramos la pantalla de victoria
                if (gameUI != null)
                {
                    gameUI.ShowWinner("PLAYER 1");
                }

                return;
            }
        }
        else
        {
            Debug.LogError("GoalManager: GameSettings no está asignado.");
        }

        SpawnNewBall();
    }
    public void Player2Goal()
    {
        player2Wins++;

        Debug.Log("Player 2 anotó! Puntos: " + player2Wins);

        // Actualizamos el marcador
        if (gameUI != null)
        {
            gameUI.UpdateScore(player1Wins, player2Wins);
        }

        // Si todavía no ganó, creamos una nueva pelota
        if (gameSettings != null)
        {
            if (player2Wins >= gameSettings.winsToWin)
            {
                Debug.Log("¡PLAYER 2 GANÓ!");

                // Mostramos la pantalla de victoria
                if (gameUI != null)
                {
                    gameUI.ShowWinner("PLAYER 2");
                }

                return;
            }
        }
        else
        {
            Debug.LogError("GoalManager: GameSettings no está asignado.");
        }

        SpawnNewBall();
    }
    void SpawnNewBall()
    {
        GameObject currentBall = GameObject.FindGameObjectWithTag("Ball");

        if (currentBall != null)
        {
            Destroy(currentBall);
        }

        Instantiate(ballPrefab, ballSpawnPoint.position, Quaternion.identity);
    }
}
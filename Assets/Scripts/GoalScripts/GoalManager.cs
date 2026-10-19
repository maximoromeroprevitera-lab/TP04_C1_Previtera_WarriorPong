using UnityEngine;
public class GoalManager : MonoBehaviour
{
    // Warning: los seis campos son public. Con [SerializeField] private los seguís viendo en el inspector y dejan de estar abiertos a todo el proyecto, que es importante justo acá porque player1Wins y player2Wins son el marcador.
    // Lo mismo en BallVelocity.cs:5, Movementplayer1.cs:4, Movementplayer2.cs:5, Goal.cs:4 y SizePlayer1/2.
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

        // Warning: quedaron ocho Debug.Log de depuración en la entrega (cuatro acá, dos en GoalTimer y dos en GameSettingsUI).
        // No inundan la consola, pero no van en la versión que se publica. Los dos LogError sí conviene dejarlos: avisan de una referencia sin asignar.
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
    // Warning: en cada gol se destruye la pelota y se instancia una nueva, y para encontrar la vieja se usa FindGameObjectWithTag, que recorre la escena.
    // La pelota es siempre la misma: guardala en un campo y agregale un Reset() que la ponga en el centro y le devuelva la velocidad inicial. Te ahorrás el Find, el Destroy y el Instantiate por punto.
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
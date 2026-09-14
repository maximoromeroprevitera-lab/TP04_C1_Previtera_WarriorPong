using UnityEngine;

public class GoalTimer : MonoBehaviour
{
    public float goalTimeLimit = 20f;
    public Transform Ball;
    public Transform CenterLimit;
    public GoalManager goalManager;
    private float currentTime = 0f;

    void Start()
    {
        Time.timeScale = 1f;

        if (CenterLimit == null)
            Debug.LogError("¡CenterLimit NO está asignado!");
        if (goalManager == null)
            Debug.LogError("¡GoalManager NO está asignado!");

        FindBall();
        currentTime = 0f;
    }

    void Update()
    {
        // Si la pelota fue destruida (gol), buscar la nueva y reiniciar
        if (Ball == null)
        {
            FindBall();
            if (Ball == null) return;
            currentTime = 0f;
        }

        currentTime += Time.deltaTime;

        if (currentTime >= goalTimeLimit)
        {
            if (CenterLimit != null && goalManager != null && Ball != null)
            {
                if (Ball.position.x < CenterLimit.position.x)
                {
                    Debug.Log("Lado Player 1 → Punto Player 2");
                    goalManager.Player2Goal();
                }
                else
                {
                    Debug.Log("Lado Player 2 → Punto Player 1");
                    goalManager.Player1Goal();
                }
            }

            currentTime = 0f;
        }
    }

    void FindBall()
    {
        GameObject ballObject = GameObject.FindGameObjectWithTag("Ball");
        if (ballObject != null) Ball = ballObject.transform;
    }
}
using UnityEngine;

public class GoalTimer : MonoBehaviour
{
    // Bug: este goalTimeLimit es un campo propio del componente y nunca lee gameSettings.goalTimeLimit. GameSettingsUI.ApplyTime escribe el valor en el ScriptableObject, pero el cronómetro que corre en la partida sigue usando este otro.
    // O sea que cambiar el tiempo desde el panel de settings no hace nada. Agregá un campo [SerializeField] private GameSettings gameSettings y leé de ahí, igual que hace GoalManager con winsToWin.
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

    // Warning: FindGameObjectWithTag se llama desde el Update cada vez que la pelota es null, o sea en todos los frames que van desde el gol hasta que aparece la nueva.
    // Si GoalManager deja de destruir la pelota (ver el Warning de GoalManager.cs:81), este método desaparece solo.
    void FindBall()
    {
        GameObject ballObject = GameObject.FindGameObjectWithTag("Ball");
        if (ballObject != null) Ball = ballObject.transform;
    }
}
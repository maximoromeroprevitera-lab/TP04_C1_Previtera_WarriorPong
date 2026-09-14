using UnityEngine;
public class Goal : MonoBehaviour
{
    public bool goalPlayer1;

    public GoalManager goalManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            if (goalPlayer1)
            {
                goalManager.Player2Goal();
            }
            else
            {
                goalManager.Player1Goal();
            }
        }
    }
}
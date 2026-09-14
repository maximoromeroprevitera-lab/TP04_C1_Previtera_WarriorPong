using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private BallVelocity ballVelocity;

    void Start()
    {
        ballVelocity = GetComponent<BallVelocity>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Golpea Player 1
        if (collision.gameObject.CompareTag("Player1"))
        {
            ballVelocity.IncreaseSpeed();

            Vector2 direction = new Vector2(
                1f,
                Random.Range(-1f, 1f)
            ).normalized;

            ballVelocity.SetDirection(direction);
        }

        // Golpea Player 2
        if (collision.gameObject.CompareTag("Player2"))
        {
            ballVelocity.IncreaseSpeed();

            Vector2 direction = new Vector2(
                -1f,
                Random.Range(-1f, 1f)
            ).normalized;

            ballVelocity.SetDirection(direction);
        }
    }
}

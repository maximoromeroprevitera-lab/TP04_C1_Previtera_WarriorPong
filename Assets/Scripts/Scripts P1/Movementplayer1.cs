using UnityEngine;
public class Movementplayer1 : MonoBehaviour
{
    public float speed = 80f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float movementY = 0f;
        float movementX = 0f;

        // Movimiento vertical
        if (Input.GetKey(KeyCode.W))
        {
            movementY = 1f;
        }

        if (Input.GetKey(KeyCode.S))
        {
            movementY = -1f;
        }

        // Movimiento horizontal
        if (Input.GetKey(KeyCode.D))
        {
            movementX = 1f;
        }

        if (Input.GetKey(KeyCode.A))
        {
            movementX = -1f;
        }

        Vector2 newPosition = rb.position;

        newPosition.y += movementY * speed * Time.fixedDeltaTime;
        newPosition.x += movementX * speed * Time.fixedDeltaTime;

        rb.MovePosition(newPosition);
    }
}
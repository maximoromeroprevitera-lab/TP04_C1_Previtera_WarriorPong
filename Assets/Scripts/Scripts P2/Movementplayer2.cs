using UnityEngine;

public class Movementplayer2 : MonoBehaviour
{
    public float speed = 5f;

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
        if (Input.GetKey(KeyCode.UpArrow))
        {
            movementY = 1f;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            movementY = -1f;
        }

        // Movimiento horizontal
        if (Input.GetKey(KeyCode.RightArrow))
        {
            movementX = 1f;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            movementX = -1f;
        }

        Vector2 newPosition = rb.position;

        newPosition.y += movementY * speed * Time.fixedDeltaTime;
        newPosition.x += movementX * speed * Time.fixedDeltaTime;

        rb.MovePosition(newPosition);
    }
}
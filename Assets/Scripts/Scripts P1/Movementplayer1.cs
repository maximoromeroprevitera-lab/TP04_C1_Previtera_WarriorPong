using UnityEngine;
// Suggestion: Movementplayer1 y Movementplayer2 son la misma clase con las teclas cambiadas, y lo mismo pasa con SizePlayer1/SizePlayer2, ChangecolorP1/ChangecolorP2 y ColorsettingsP1/ColorsettingsP2. Son cuatro pares de archivos duplicados.
// Serializá las cuatro KeyCode (como ya hacés con el color) y dejá una sola clase por responsabilidad: pasás de ocho archivos a cuatro y cada arreglo se hace una vez.
public class Movementplayer1 : MonoBehaviour
{
    public float speed = 80f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Suggestion: en Game.unity quedó un objeto llamado Square en el centro de la cancha (world x = 371) con un BoxCollider2D de 1.88 por 4.79 que no es trigger. Si era decorativo (la línea del medio), sacale el collider: hoy la pelota puede rebotar contra él.
    // Y si la idea era que sea el límite del medio que menciona el README, tiene que ser alto como la cancha (unos 460 de alto), no 4.79.
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
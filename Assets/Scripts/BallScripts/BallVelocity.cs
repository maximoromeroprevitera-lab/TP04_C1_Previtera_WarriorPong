using UnityEngine;
public class BallVelocity : MonoBehaviour
{
    // Velocidad inicial
    public float speed = 80f;

    // Cuánto aumenta la velocidad después de cada golpe
    public float speedIncrease = 10f;

    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // Dirección inicial: derecha y arriba
        Vector2 direction = new Vector2(1f, 1f).normalized;

        // Aplica la velocidad inicial
        rb.linearVelocity = direction * speed;
    }
    void FixedUpdate()
    {
        // Si el juego está pausado, no modificamos la velocidad
        if (Time.timeScale == 0)
            return;

        // Mantiene la velocidad sin cambiar la dirección
        if (rb.linearVelocity.magnitude > 0)
        {
            rb.linearVelocity = rb.linearVelocity.normalized * speed;
        }
    }
    public void IncreaseSpeed()
    {
        speed += speedIncrease;
    }
    public void SetDirection(Vector2 direction)
    {
        rb.linearVelocity = direction * speed;
    }
}
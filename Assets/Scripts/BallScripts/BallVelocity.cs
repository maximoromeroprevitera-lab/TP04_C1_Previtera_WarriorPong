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
        // Warning: comparar Time.timeScale con == contra 0 es comparar dos floats. Además, con timeScale en 0 el FixedUpdate directamente no corre, así que el chequeo no hace falta.
        // Borrá las dos líneas.
        if (Time.timeScale == 0)
            return;

        // Mantiene la velocidad sin cambiar la dirección
        if (rb.linearVelocity.magnitude > 0)
        {
            rb.linearVelocity = rb.linearVelocity.normalized * speed;
        }
    }
    // Warning: la velocidad sube 10 en cada golpe y no hay ningún tope. Arranca en 80, así que a los veinte golpes va a 280 y la pelota se mueve más de lo que mide el collider entre frame y frame: la atraviesa sin rebotar.
    // Acotalo: speed = Mathf.Min(speed + speedIncrease, maxSpeed), con maxSpeed serializado.
    public void IncreaseSpeed()
    {
        speed += speedIncrease;
    }
    public void SetDirection(Vector2 direction)
    {
        rb.linearVelocity = direction * speed;
    }
}
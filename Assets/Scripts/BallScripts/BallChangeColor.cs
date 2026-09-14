using UnityEngine;
public class BallChangeColor : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player1") ||
            collision.gameObject.CompareTag("Player2"))
        {
            Color randomColor = new Color(
                Random.value,
                Random.value,
                Random.value
            );

            spriteRenderer.color = randomColor;
        }
    }
}
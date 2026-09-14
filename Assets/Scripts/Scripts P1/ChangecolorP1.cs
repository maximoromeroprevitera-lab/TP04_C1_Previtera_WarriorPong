using UnityEngine;
public class ChangecolorP1 : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    private Color previousColor;
    private bool touchingLimit = false;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        previousColor = spriteRenderer.color;
    }

    public void ChangeColor(Color color)
    {
        spriteRenderer.color = color;

        if (!touchingLimit)
        {
            previousColor = color;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Color randomColor = new Color(
                Random.value,
                Random.value,
                Random.value
            );

            ChangeColor(randomColor);
        }

        if (collision.gameObject.CompareTag("Limit"))
        {
            touchingLimit = true;
            spriteRenderer.color = Color.black;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Limit"))
        {
            touchingLimit = false;
            spriteRenderer.color = previousColor;
        }
    }
}
using UnityEngine;
// Error: el archivo se llama ChagecolorP2.cs (le falta la 'n') y la clase ChangecolorP2. Unity busca dentro de cada .cs una clase con el mismo nombre que el archivo; cuando no la encuentra, el componente no se puede agregar y los que ya están puestos pueden aparecer como Missing Script.
// Es exactamente el mismo archivo que te marqué en el TP03. Renombralo desde el Project de Unity para que el .meta viaje con él.
public class ChangecolorP2 : MonoBehaviour
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
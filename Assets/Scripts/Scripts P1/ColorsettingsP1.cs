using UnityEngine;

public class ColorsettingsP1 : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void ChangeColor(int option)
    {
        switch (option)
        {
            case 0:
                spriteRenderer.color = Color.red;
                break;

            case 1:
                spriteRenderer.color = Color.blue;
                break;

            case 2:
                spriteRenderer.color = Color.green;
                break;

            case 3:
                spriteRenderer.color = Color.yellow;
                break;

            case 4:
                spriteRenderer.color = new Color32(128, 0, 255, 255);
                break;
        }
    }
}
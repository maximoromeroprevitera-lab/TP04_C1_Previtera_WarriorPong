using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class SizePlayer2 : MonoBehaviour
{
    public Slider slider;
    public TMP_Text sizeText;

    public void ChangeSize()
    {
        Vector3 scale = transform.localScale;

        scale.y = slider.value;

        transform.localScale = scale;

        sizeText.text = "Tamaño: " + slider.value.ToString("F1");
    }
}
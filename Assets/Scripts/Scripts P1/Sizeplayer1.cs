using UnityEngine;
using UnityEngine.UI;
using TMPro;
// Warning: el archivo se llama Sizeplayer1.cs y la clase SizePlayer1, con la P mayúscula. Lo mismo pasa en Sizeplayer2.cs y en Exitgame.cs (clase ExitGame).
// En Windows el sistema de archivos no distingue mayúsculas, así que puede que hoy funcione, pero en Game.unity el componente todavía guarda m_EditorClassIdentifier: Assembly-CSharp::Sizeplayer1, que es el nombre del archivo y no el de la clase.
// Unificá los tres nombres desde el Project de Unity y verificá en el editor que los componentes no aparezcan como Missing Script.
public class SizePlayer1 : MonoBehaviour
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
using UnityEngine;
public class CameraAdjust : MonoBehaviour
{
    public float targetWidth = 19.2f; // Ancho de tu cancha en unidades Unity

    void Start()
    {
        Camera cam = GetComponent<Camera>();

        // Ajustar el orthographic size según la relación de aspecto
        float targetRatio = targetWidth / (cam.orthographicSize * 2f);
        float currentRatio = (float)Screen.width / Screen.height;

        if (currentRatio < targetRatio)
        {
            cam.orthographicSize = targetWidth / (2f * currentRatio);
        }
    }
}
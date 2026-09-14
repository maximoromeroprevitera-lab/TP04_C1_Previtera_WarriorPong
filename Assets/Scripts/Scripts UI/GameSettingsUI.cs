using UnityEngine;
using TMPro;
public class GameSettingsUI : MonoBehaviour
{
    public GameSettings gameSettings;

    public TMP_InputField inputTime;
    public TMP_InputField inputWins;

    void Start()
    {
        // Mostrar los valores actuales del GameSettings
        inputTime.text = gameSettings.goalTimeLimit.ToString();
        inputWins.text = gameSettings.winsToWin.ToString();
    }

    // Cambiar el tiempo para hacer un gol
    public void ApplyTime()
    {
        if (float.TryParse(inputTime.text, out float newTime))
        {
            if (newTime > 0)
            {
                gameSettings.goalTimeLimit = newTime;

                Debug.Log("Nuevo tiempo para gol: " + gameSettings.goalTimeLimit);
            }
        }
    }

    // Cambiar las victorias necesarias para ganar
    public void ApplyWins()
    {
        if (int.TryParse(inputWins.text, out int newWins))
        {
            if (newWins > 0)
            {
                gameSettings.winsToWin = newWins;

                Debug.Log("Nuevas victorias necesarias: " + gameSettings.winsToWin);
            }
        }
    }
}
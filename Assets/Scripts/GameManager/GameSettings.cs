using UnityEngine;

[CreateAssetMenu(fileName = "GameSettings", menuName = "Pong/Game Settings")]
public class GameSettings : ScriptableObject
{
    // Tiempo máximo para hacer un gol
    public float goalTimeLimit = 20f;

    // Cantidad de puntos necesarios para ganar
    public int winsToWin = 3;
}
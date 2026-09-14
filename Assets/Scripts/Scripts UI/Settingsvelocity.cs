using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Settingsvelocity : MonoBehaviour
{
    public Movementplayer1 player1;
    public Movementplayer2 player2;

    public Slider Sliderplayer1;
    public Slider Sliderplayer2;

    public TMP_Text Speedplayer1text;
    public TMP_Text Speedplayer2text;

    void Start()
    {
        Sliderplayer1.value = player1.speed;
        Sliderplayer2.value = player2.speed;

        Speedplayer1text.text = "Speed: " + player1.speed;
        Speedplayer2text.text = "Speed: " + player2.speed;
    }

    public void ChangeSpeedPlayer1(float newSpeed)
    {
        player1.speed = newSpeed;
        Speedplayer1text.text = "Speed: " + newSpeed;
    }

    public void ChangeSpeedPlayer2(float newSpeed)
    {
        player2.speed = newSpeed;
        Speedplayer2text.text = "Speed: " + newSpeed;
    }
}
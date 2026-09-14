using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Playbutton : MonoBehaviour
{
    public GameObject Mainmenu;

    public void Play()
    {
        Mainmenu.SetActive(false);
        SceneManager.LoadScene("Game");
    }
}
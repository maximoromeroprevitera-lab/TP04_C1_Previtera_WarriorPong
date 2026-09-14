using UnityEngine;

public class Credits : MonoBehaviour
{
    public GameObject Creditspanel;

    public void Open()
    {
        Creditspanel.SetActive(true);
    }

    public void Close()
    {
        Creditspanel.SetActive(false);
    }
}

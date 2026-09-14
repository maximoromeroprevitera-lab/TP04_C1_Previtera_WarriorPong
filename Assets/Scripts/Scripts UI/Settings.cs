using UnityEngine;

public class Settings : MonoBehaviour
{
    public GameObject Settingpanel;

    public void Opensettings()
    {
        Settingpanel.SetActive(true);
    }

    public void Closesettings()
    {
        Settingpanel.SetActive(false);
    }
}
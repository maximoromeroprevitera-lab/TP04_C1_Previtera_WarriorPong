using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public void Exit()
    // Warning: Application.Quit() sin el bloque #if UNITY_EDITOR. En el build funciona, pero en el editor el botón no hace nada y parece roto. Lo mismo en Menu.cs:36, Pausemenu.cs:51 y VictoryUI.ExitGame.
    // Ya tenés la versión correcta escrita en Quit.cs: usá ese script para los cuatro botones y borrá los otros tres métodos.
    {
        Application.Quit();
    }
}
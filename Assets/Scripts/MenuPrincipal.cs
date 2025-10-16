using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public void Multiplayer()
    {
        Debug.Log("Entrando en modo multijugador");
        SceneManager.LoadScene("Multijugador");
    }
    public void Singleplayer()
    {
        Debug.Log("Entrando en modo un jugador");
        SceneManager.LoadScene("UnJugador");
    }
    public void Exit()
    {
        Debug.Log("Saliendo del juego");
        Application.Quit();
    }
}

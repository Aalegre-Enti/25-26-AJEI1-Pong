using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int puntA;
    public TMP_Text puntAText;
    public int puntB;
    public TMP_Text puntBText;

    private void Update()
    {
        puntAText.text = puntA.ToString();
        puntBText.text = puntB.ToString();

        if (puntA > 10)
        {
            Debug.Log("Jugador A ha ganado");
            SceneManager.LoadScene("MenuPrincipal");
        }
        if (puntB > 10)
        {
            Debug.Log("Jugador B ha ganado");
            SceneManager.LoadScene("MenuPrincipal");
        }
    }
}

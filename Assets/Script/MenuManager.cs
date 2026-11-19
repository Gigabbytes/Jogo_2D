using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour
{
    public void StarGame()
    {
        SceneManager.LoadScene("Fase 1"); // carrega a cena "Fase 1"

    }

    public void QuitGame() // função botão Sair
    {

     Application.Quit(); // fecha o jogo

    }












}

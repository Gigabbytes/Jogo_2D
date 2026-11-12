using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour
{
    public void StarGame()
    {
        SceneManager.LoadScene("Fase 1");

    }

    public void QuitGame()
    {

     Application.Quit();

    }












}

using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuScene : MonoBehaviour
{
    public GameObject painelPause;          // o painel que aparece quando o jogo tá pausado
    public GameObject painelGameOver;       // o painel  da tela de game over
    bool pausado = false;                   // começa sem estar pausado
    bool jogoAcabou = false;                // começa com o jogo rolando(logcio ne -_-)
    void Start()                          
    {
        painelPause.SetActive(false);       // esconde o painel de pause pra ele não aparecer de cara
        painelGameOver.SetActive(false);    // esconde o de game over também
    }


    void Update()                           
    {
        if (Input.GetKeyDown(KeyCode.Escape))   // apertou o Esc?
        {
            if (pausado)                    // se já tava pausado...
            {
                Continuar();                // ...volta pro jogo
            }
            else                            // se não tava pausado...
            {
                Pausar();                   // ...pausa
            }
        }
    }

    public void Pausar()                    // função que pausa o jogo
    {
        if (jogoAcabou == false)            // só deixa pausar se o jogo não acabou 
        {
            pausado = true;                 // anota que tá pausado
            painelPause.SetActive(true);    // mostra o painel de pause
            Time.timeScale = 0f;            // congela o tempo do jogo
        }
    }

    public void Continuar()                 // função que despausa
    {
        pausado = false;                    // anota que não tá mais pausado
        painelPause.SetActive(false);       // esconde o painel de pause
        Time.timeScale = 1f;                // o tempo volta ao normal
    }

    public void MostrarGameOver()           // chamada quando o jogador morre (tipo no scprit de Dano)
    {
        jogoAcabou = true;                  // anota que o jogo acabou aí o Esc não pausa mais
        painelGameOver.SetActive(true);     // mostra a tela de game over
        Time.timeScale = 0f;                // congela o jogo
    }

    public void Reiniciar()                 // função do botão "Reiniciar"
    {
        Time.timeScale = 1f;                // descongela o tempo antes senão a cena nova nasce travada
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);   // recarrega a cena que tá aberta agora

    }

    public void VoltarMenu()                // função do botão "Voltar ao menu"
    {
        Time.timeScale = 1f;                // descongela o tempo também, pelo mesmo motivo
        SceneManager.LoadScene(0);          // carrega a cena de índice 0 do Build Settings normalmente o menu principal

    }








}
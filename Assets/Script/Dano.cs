using UnityEngine;
using UnityEngine.SceneManagement;
public class Dano : MonoBehaviour
{
    private Vector3 inicio; // guarda uma posição inicial
    float invencibilidade = 0f;  // o cronômetro da imortalidade
    bool imortal = false;  // false = pode morrer, true = tá invencível
    public MenuScene menu;  // é quem mostra a tela de game over

    void Start()
    {
        

        invencibilidade -= Time.deltaTime; // diminui o cronômetro 

        if (Input.GetKeyDown(KeyCode.E)) // checa se apertou o E, mas no Start isso quase nunca acontece
        {
            invencibilidade = 10f;  // dar 10 segundos de imortalidade

        } 

       

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) // apertou o E neste frame?
        {
            invencibilidade = 10f;   // então enche o cronômetro com 10 segundos


        }
        if (invencibilidade > 0f) // ainda sobrou tempo no cronômetro?
        {
            imortal = true;   // então tá imortal
            invencibilidade -= Time.deltaTime; // e vai gastando o tempo, frame a frame
        } else
        { 
            imortal = false;     // volta a ser mortal
        }
    }


    private void OnCollisionEnter2D(Collision2D collision) // roda quando o objeto bate em outro com collider 2D
    {
        if (collision.collider.CompareTag("Espinho") && imortal == false) // bateu num espinho E não tá imortal?
        {
            menu.MostrarGameOver();  // Cabou, mostra a tela de game over
        }
    }

}

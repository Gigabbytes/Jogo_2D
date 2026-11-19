using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)   // roda quando o personagem bate em algo com collider 2D
    {
        if (collision.collider.CompareTag("Portal"))        // bateu em algo com a tag "Portal"?
        {
            SceneManager.LoadScene("Fase 2");               // então carrega a cena "Fase 2"

        }


        if ((collision.collider.CompareTag("PortalF")))     // bateu em algo com a tag "PortalF" (o portal final)?
        {
            SceneManager.LoadScene("End Game");             // então carrega a cena "End Game", o fim do jogo
        }
    }



}

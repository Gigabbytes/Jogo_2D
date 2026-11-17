using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Portal"))
        {
            SceneManager.LoadScene("Fase 2");
      
        }


        if ((collision.collider.CompareTag("PortalF")))
        {
            SceneManager.LoadScene("End Game");
        }
    }   



}

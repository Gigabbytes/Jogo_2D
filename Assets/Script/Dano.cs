using UnityEngine;
using UnityEngine.SceneManagement;
public class Dano : MonoBehaviour
{
    private Vector3 inicio;
    float invencibilidade = 0f;
    bool imortal = false;
    void Start()
    {
        

        invencibilidade -= Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.E))
        {
            invencibilidade = 10f;

        } 

       

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            invencibilidade = 10f;

        }
        if (invencibilidade > 0f)
        {
            imortal = true;
            invencibilidade -= Time.deltaTime;
        } else
        {
            imortal = false;
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Espinho") && imortal == false)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

}

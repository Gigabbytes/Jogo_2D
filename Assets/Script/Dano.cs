using UnityEngine;

public class Dano : MonoBehaviour
{
    private Vector3 inicio;
    void Start()
    {
        inicio = transform.position;
    }

    
    private void OnTriggerEnter2D(Collider2D other)
    {

        {
            if (other.CompareTag("Espinho"))
            {
                transform.position = inicio;
            }


        }
    }
}

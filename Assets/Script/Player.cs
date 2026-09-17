using JetBrains.Annotations;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;
   private Rigidbody2D rb;
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();


    }

    
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); //Reconhece o MoviHorizonal e adiciona a tecla A e D com teclas para movimentos
        rb.linearVelocity = new Vector2(moveHorizontal * speed, rb.linearVelocity.y); // 

        if(Input.GetKey(KeyCode.Space))
        {

          rb.AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse);


        }
    }
}

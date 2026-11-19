using JetBrains.Annotations;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;                // a velocidade de andar 
    private Rigidbody2D rb;                 // vai guardar o Rigidbody2D do personagem, é ele que aplica a física
    private bool isGrounded = false;        // false = tá no ar, true = tá pisando no chão
    void Start()                            
    {

        rb = GetComponent<Rigidbody2D>();   // pega o Rigidbody2D que tá no próprio personagem e guarda no rb


    }


    void Update()                           
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); // lê as teclas A/D (ou setas): -1 pra esquerda, 1 pra direita, 0 parado
        rb.linearVelocity = new Vector2(moveHorizontal * speed, rb.linearVelocity.y); // define a velocidade X e mantém o Y como tá 

        if (Input.GetKeyDown(KeyCode.Space)&& isGrounded)   // apertou Espaço E tá no chão? para evita pulo no ar
        {

            rb.AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse);   // dá um empurrão pra cima de uma vez só, que é o pulo


        }

    }


    void OnCollisionEnter2D(Collision2D collision)   // roda quando o personagem encosta em alguma coisa
    {
        if (collision.gameObject.CompareTag("Ground"))   // encostou em algo com a tag "Ground"?
        {
            isGrounded = true;              // então tá no chão e pode pular de novo


        }
    }
    void OnCollisionExit2D(Collision2D collision)   // roda quando o personagem para de encostar em alguma coisa
    {

        if (collision.gameObject.CompareTag("Ground"))   // era algo com a tag "Ground"?
        {

            isGrounded = false;             // então saiu do chão, tá no ar e não pode pular

        }
    }





}



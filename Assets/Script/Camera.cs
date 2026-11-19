using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform player; // Transform guarda posição do player
    public float velocidade = 5f; // quanto maior, mais rápido a câmera corre atrás do player
    void Start()
    {
        
    }
    void LateUpdate()
    {
        Vector3 novaPosicao = new Vector3(  // monta o ponto pra onde a câmera quer ir
            player.position.x, // mesmo X do player (esquerda/direita)
            player.position.y,   // mesmo Y do player (cima/baixo)
            transform.position.z    // mantém o Z, senão a câmera entra no cenário e some :/
        );

        transform.position = Vector3.Lerp( // move a câmera de boa, deslizando, sem teleportar, suave
            transform.position,  // de onde ela tá agora
            novaPosicao,        // até onde ela quer chegar
            velocidade * Time.deltaTime  // o tanto que ela anda por frame 
        );
    }
}
    
    


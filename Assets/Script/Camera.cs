using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform player;
    public float velocidade = 5f;
    void Start()
    {
        
    }
    void LateUpdate()
    {
        Vector3 novaPosicao = new Vector3(
            player.position.x,
            player.position.y,
            transform.position.z
        );

        transform.position = Vector3.Lerp(
            transform.position,
            novaPosicao,
            velocidade * Time.deltaTime
        );
    }
}
    
    


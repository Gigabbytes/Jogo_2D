using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform alvo;                                  // quem a câmera vai seguir 
    public Vector3 distancia = new Vector3(0f, 0f, -10f);   // o afastamento da câmera em relação ao alvo 
    public bool movimentoSuave = true;                      // marcado = câmera desliza; desmarcado = fica grudada no alvo
    public float velocidade = 5f;                           // quão rápido ela alcança o alvo 

    void LateUpdate()                                       
    {
        Vector3 posicaoDesejada = alvo.position + distancia;    // calcula onde a câmera quer ficar: posição do alvo + o afastamento
        if (movimentoSuave)                                 // se o modo suave tá ligado...
        {

            transform.position = Vector3.Lerp(transform.position, posicaoDesejada, velocidade + Time.deltaTime);   // ...desliza da posição atual até a desejada
        }
        else                                                // se o modo suave tá desligado...
        {
            transform.position = posicaoDesejada;           // ...teleporta direto pra posição desejada, colada no alvo

        }
    }
 }

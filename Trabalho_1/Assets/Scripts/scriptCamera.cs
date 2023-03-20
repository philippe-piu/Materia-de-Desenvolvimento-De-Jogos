using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptCamera : MonoBehaviour
{
    //PlayPlue é o meu personagem principal estou fazendo uma referência ele aqui para camera o seguir
    public GameObject PlayPlue;
    //Posição da câmera para o personagem principal
    private float offsetY = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Mantendo a profundidade da câmera para o personagem
        Vector3 posicao = new Vector3(PlayPlue.transform.position.x, PlayPlue.transform.position.y + offsetY, -10);
        transform.position = posicao;
    }
}

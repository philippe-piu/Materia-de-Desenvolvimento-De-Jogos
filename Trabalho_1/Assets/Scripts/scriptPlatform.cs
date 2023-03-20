using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptPlatform : MonoBehaviour
{
    private float deslocamento = 2f;
    private float contador = 0;
    private Vector2 posiInicial;
    public float distanciaMaiorX;
    public float distanciaMaiorY;
    // Start is called before the first frame update
    void Start()
    {
        posiInicial = transform.position;
        distanciaMaiorX = 1;
        //distanciaMaiorY 0 me ajuda a movimentar na Horizontal a plataforma
        distanciaMaiorY = 0;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Mathf.Sin(contador) * distanciaMaiorX;
        float y = Mathf.Cos(contador) * distanciaMaiorY;

        transform.position = new Vector2(posiInicial.x + x, posiInicial.y + y);
        contador += deslocamento * Time.deltaTime;

        if(contador >= 2 * Mathf.PI)
            contador = 0;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class geradorDeEnergia : MonoBehaviour
{

    public PolygonCollider2D[] col;

    public int tempoDeProducao = 30;
    public int quantidadeDeProducao = 10;
    public int custoDeConstrucao;
    public float variacaoDePosicao = 0.04f;
    public GameObject[] objeto;
    float intTimer;

    
    // Start is called before the first frame update
    void Start()
    {

        foreach(PolygonCollider2D off in col){

            off.enabled = true;

        }

        reiniciaTimer(tempoDeProducao);
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (intTimer < Time.time){

            novaUnidade(quantidadeDeProducao);
            reiniciaTimer(tempoDeProducao);

        }
        
    }

    public void reiniciaTimer(int valor){

        intTimer = Time.time + valor;

    }

    public void novaUnidade(int quant){

        for (int i = 0; i < quant; i++) {

            //Randomiza posição
            Vector3 novaPos =  new Vector3(Random.Range(-variacaoDePosicao, variacaoDePosicao),
                                            Random.Range(-variacaoDePosicao, variacaoDePosicao),
                                            Random.Range(-variacaoDePosicao, variacaoDePosicao));

            //Instancia nova unidade de energia
            Instantiate(objeto[Random.Range(0, objeto.Length)], transform.position + novaPos, Quaternion.identity);
            
        }

    }


}

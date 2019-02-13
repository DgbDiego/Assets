using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class geradorDeEnergia : MonoBehaviour
{

    public int tempoDeProducao = 30;
    public int quantidadeDeProducao = 10;
    float intTimer;

    
    // Start is called before the first frame update
    void Start()
    {

        reiniciaTimer(tempoDeProducao);
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (intTimer < Time.time){

            reiniciaTimer(tempoDeProducao);

        }
        
    }

    public void reiniciaTimer(int valor){

        intTimer = Time.time + valor;

    }

    public void novaUnidade(){

        for (int i = 0; i < quantidadeDeProducao; i++) {

            //Instancia nova unidade de energia
            
        }


    }


}

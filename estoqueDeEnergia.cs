using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class estoqueDeEnergia : MonoBehaviour
{

    public int _capacidade;
    public bool criado = false;

    
    // Start is called before the first frame update
    void Start()
    {

        
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        if(!criado && transform.parent == null){

            GameObject.FindGameObjectWithTag("GameController").GetComponent<contadorDeEnergia>()._capacidade += _capacidade;            
            criado = true;
        }
        
    }

    private void OnDestroy() {

        GameObject.FindGameObjectWithTag("GameController").GetComponent<contadorDeEnergia>()._capacidade -= _capacidade;

        
    }
}

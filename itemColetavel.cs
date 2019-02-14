using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemColetavel : MonoBehaviour
{
    bool usado = false;
    public float velocidadeFlutuante = 0.02f;
    public int valor = 3;   

    void Update(){

        if(usado || transform.position.y > 8f)
        Destroy(gameObject);

        transform.position += Vector3.up * velocidadeFlutuante;    

    } 
    public int itemUsado(){

        usado = true;
        return valor;       

    }
    
}
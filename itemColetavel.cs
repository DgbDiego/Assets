using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemColetavel : MonoBehaviour
{

    public Vector3 posicaoDestino;    

    public void itemUsado(){

        transform.position = posicaoDestino;
        Debug.Log("ItemUsadoooOOOOooOOOo");

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct estruturaDeItem
{

    public GameObject item;
    public int custo;   

    public estruturaDeItem(GameObject item, int cst){

        this.item = item;
        this.custo = cst;
        
    }

    
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class btnStatus : MonoBehaviour
{

    public bool botaoAtivado;
    public GameObject itemDoBotao;
    public int custoDoItem;
    // Start is called before the first frame update
    void Start()
    {

        custoDoItem = itemDoBotao.GetComponent<geradorDeEnergia>().custoDeConstrucao;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        botaoAtivado = GetComponent<Button>().interactable;
            
    }
}

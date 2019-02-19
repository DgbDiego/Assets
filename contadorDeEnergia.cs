using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class contadorDeEnergia : MonoBehaviour
{

    public Text _energiaDial;
    
    public GameObject[] itens;
    public int _energia;
    public int _capacidade = 50;
    int _intEnergia;

    public float _frequenciaEnergia;

    // Start is called before the first frame update
    void Start()
    {

        revisaItens();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        _energiaDial.text = _energia.ToString();

        if (_intEnergia != _energia){

            if (_intEnergia > _capacidade){
                _intEnergia = _capacidade;
            } else if (_intEnergia < 0){
                _intEnergia = 0;
            }

            _intEnergia = _energia;
            revisaItens();

            

        }     
        
    }

    public void revisaItens(){

        foreach(GameObject item in itens){


            print("ListandoItens");

            if (item.GetComponent<btnStatus>().custoDoItem <= _energia){

                item.GetComponent<Button>().interactable = true;

            } else {
                
                item.GetComponent<Button>().interactable = false;

            }   

        }            

    }

}

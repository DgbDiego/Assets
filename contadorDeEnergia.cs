using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class contadorDeEnergia : MonoBehaviour
{

    public Text _energiaDial;
    
    public GameObject[] itens;
    public int _energia;
    int _intEnergia;

    public float _frequenciaEnergia;

    float intTimer;


    // Start is called before the first frame update
    void Start()
    {

        intTimer = Time.time + _frequenciaEnergia;
        revisaItens();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        _energiaDial.text = _energia.ToString();

        if (_intEnergia != _energia || intTimer < Time.time){

            _intEnergia = _energia;
            revisaItens();

            intTimer = Time.time + _frequenciaEnergia;
            

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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eventosDoMouse : MonoBehaviour
{     

    public bool BaseCorreta;

    public string tagAlvos;   
    public Camera cam;
    public Vector2 mousePos;

    RaycastHit2D hit;

    public GameObject itemCriado;
    int custoAtual;

    // Update is called once per frame
    void Update() {

        mirandoComMouse();

        if (itemCriado){

            if (Input.GetButtonUp("Fire1")){

                if (BaseCorreta){

                    Transform destino = hit.transform.parent.parent.transform;
                    

                    //Debug.Log(hit.transform.parent.parent.name);                
                    itemCriado.transform.position = destino.position;
                    itemCriado.transform.rotation = destino.rotation;
                    itemCriado.transform.parent = destino;
                    GetComponent<contadorDeEnergia>()._energia -= custoAtual;
                    itemCriado = null;

                    Destroy(hit.transform.parent.gameObject);                    


                } else {

                    Destroy(itemCriado);
                }

                

            } else {

                itemCriado.transform.position = mousePos;                

            }

        }
        
    }

    public void mirandoComMouse(){

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        hit = Physics2D.Raycast (mousePos,Vector2.zero, Mathf.Infinity);

        if (hit){


            if (hit.transform.parent.CompareTag(tagAlvos)){

                BaseCorreta = true;

            } else {

                BaseCorreta = false;

            }
        }

    }

    public void BtnPressItem(btnStatus status){

        if (status.botaoAtivado){

            itemCriado = status.itemDoBotao;

            custoAtual = status.custoDoItem;

            itemCriado = Instantiate (itemCriado, Input.mousePosition, Quaternion.identity);

        }

    }
}

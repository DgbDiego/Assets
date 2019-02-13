using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eventosDoMouse : MonoBehaviour
{     

    public bool BaseCorreta;
    public GameObject objetoAcertado;
    public GameObject itemCriado;

    public string tagAlvos;   
    public Camera cam;
    public Vector2 mousePos;
    RaycastHit2D hit;

    
    int custoAtual;

    // Update is called once per frame
    void Update() {

        //mirandoComMouse();
        guardaItem();

        if (objetoAcertado){

            if (Input.GetButtonDown("Fire1")){

                switch(objetoAcertado.tag){

                    case "Coletavel":
                        itemColetado(objetoAcertado);
                        break;

                    default:
                        break;

                }

            } else if (Input.GetButtonUp("Fire1")){

                if (objetoAcertado.CompareTag("Construcao")){

                    instalaNovoItem();

                } else {

                    Destroy(itemCriado);

                }

            }

        } else if (Input.GetButtonUp("Fire1")){
            
            if (itemCriado){

                Destroy(itemCriado);

            }

        }

        if (itemCriado){

            itemCriado.transform.position = mousePos;

        }
        
    }

    public void instalaNovoItem(){

        Transform destino = hit.transform.parent.parent.transform;

        itemCriado.transform.position = destino.position;
        itemCriado.transform.rotation = destino.rotation;
        itemCriado.transform.parent = destino;
        itemCriado.GetComponent<geradorDeEnergia>().enabled = true;
        itemCriado = null;

        GetComponent<contadorDeEnergia>()._energia -= custoAtual;

        Destroy(hit.transform.parent.gameObject);
        Debug.Log("Destruido: " + hit.transform.parent.name);

    }

    public void guardaItem(){

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);   

        hit = Physics2D.Raycast (mousePos, Vector2.zero, Mathf.Infinity);

        if (hit){

            objetoAcertado = hit.transform.gameObject;

        } else {

            objetoAcertado = null;
        }
    }

    public void itemColetado(GameObject item){

        //Adiciona valor de item Coletado

        //Destroi objeto
        Destroy(item.gameObject);

    }

    public void BtnPressItem(btnStatus status){

        if (status.botaoAtivado){

            itemCriado = status.itemDoBotao;

            custoAtual = status.custoDoItem;

            itemCriado = Instantiate (itemCriado, Input.mousePosition, Quaternion.identity);

        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class populaPlanetaInicial : MonoBehaviour
{
    public GameObject[] _objetosIniciais;
    public GameObject[] _pontosDeSpawn;
    // Start is called before the first frame update
    void Start()
    {

        foreach (GameObject ponto in _pontosDeSpawn){

            GameObject destino = ponto.transform.GetChild(0).gameObject;

            int sel = Random.Range(0, _objetosIniciais.Length);

            GameObject novoEnfeite = Instantiate (_objetosIniciais[sel], destino.transform.position, destino.transform.rotation) as GameObject;
            novoEnfeite.transform.parent = destino.transform;


        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

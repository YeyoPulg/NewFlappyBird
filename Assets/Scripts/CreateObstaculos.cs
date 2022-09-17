using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CreateObstaculos : MonoBehaviour
{
    public float maxtime = 10; //TIEMPO QUE DEMORA EN CREAR OBSTACULO
    private float initime = 0; 
    public GameObject obstaculo; //OBJETO PARA CREAR LOS OBSTACULOS
    public float altura; //VARIABLE PARA ALTURA DE OBSTACULOS

    // Start is called before the first frame update
    void Start()
    {
        GameObject newobstaculo = Instantiate(obstaculo); //SIGUIENTE OBTACULO
        newobstaculo.transform.position = transform.position + new Vector3(0,0,0); //INSTANCIAMIENTO
        Destroy(gameObject, 100); //DESTRUCCIÓN DE OBSTACULO PARA NO OCUPAR MEMORIA
    }

    // Update is called once per frame
    void Update()
    {
        if (initime > maxtime) {
            GameObject newobstaculo = Instantiate(obstaculo); //SIGUIENTE OBTACULO
            newobstaculo.transform.position = transform.position + new Vector3(0, Random.Range(-altura, altura), 0); //INSTANCIAMIENTO
            Destroy(gameObject, 100); //DESTRUCCIÓN DE OBSTACULO
            initime = 0;
        }
        else
        {
            initime += Time.deltaTime; //SI NO SE HA CUMPLIDO EL TIEMPO
        }
    }
}

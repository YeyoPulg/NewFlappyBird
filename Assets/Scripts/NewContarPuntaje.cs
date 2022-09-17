using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewContarPuntaje : MonoBehaviour
{
    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) //FUNCION PARA CONTEO DE PUNTAJE
    {
        ContarPuntaje.numpuntaje++;
    }
}

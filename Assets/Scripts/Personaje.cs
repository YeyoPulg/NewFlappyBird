using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    public float velocity = 1;
    private Rigidbody2D rb; //MANEJO DE LEYES FIICAS O GRAVEDAD DEL PERDONAJE

    public ControlScene controlScene; //LLAMADO DE CONTROLADOR PARA LAS ESCENA DE PERDER E INICIAR
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) { //APRETAR CLIC O PANTALLA
            rb.velocity = Vector2.up * velocity;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) //FUNCION PARA DETECTAR COLISIÓN
    {
        controlScene.perder(); //SI HAY COLICIÓN MOSTRAS CANVAS PERDER
    }
}

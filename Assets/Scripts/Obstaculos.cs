using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculos : MonoBehaviour
{
    public float velocidad; //VELOCIDAD CON EL QUE SE MOVERA EL OBSTACULO

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * velocidad * Time.deltaTime; //DIRRECCIÓN DONDE SE MUEVE EL OBSTACULO
    }
}

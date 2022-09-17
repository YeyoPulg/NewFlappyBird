using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ControlScene : MonoBehaviour
{
    public GameObject GameOver; //VARIABLE PARA CANVAS PERDER

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void perder() //FUNCION GAMEOVER
    {
        GameOver.SetActive(true); //CUANDO SE LLAME LA FUNCION SE ACTIVA EL CANVAS
        Time.timeScale = 0;
    }

    public void iniciar() //FUNCION DEL BOTON PLAY PARA REINICIAR EL JUEGO
    {
        SceneManager.LoadScene(0); //SE REINICIA LA ESCENA
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CambioPantalla : MonoBehaviour
{
    private string movipantalla;

    public void Movipantalla(string pantalla)
    {
        movipantalla = pantalla;
        SceneManager.LoadScene(pantalla);
    }

    public void Salir()
    {
        Application.Quit();
    }


}

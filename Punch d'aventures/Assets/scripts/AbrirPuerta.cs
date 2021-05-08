using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class AbrirPuerta : MonoBehaviour
{
    public Text text;
    public string levelNombre;
    private bool inDoor = false;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Jugador"))
        {
            text.gameObject.SetActive(true);
            inDoor = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        text.gameObject.SetActive(false);
        inDoor = false;
    }

    private void Update()
    {
        if (inDoor && Input.GetKey("e"))
        {
            SceneManager.LoadScene(levelNombre);
        }
    }
}

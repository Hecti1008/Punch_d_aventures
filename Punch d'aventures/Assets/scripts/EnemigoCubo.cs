using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoCubo : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Jugador"))
        {
            Debug.Log("Da�o Jugador");
            Destroy(collision.gameObject);
        }
    }
}

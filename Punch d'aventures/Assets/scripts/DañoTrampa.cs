using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DañoTrampa : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Jugador"))
        {
            Debug.Log("Daño Jugador");
            Destroy(collision.gameObject);
        }
    }
}

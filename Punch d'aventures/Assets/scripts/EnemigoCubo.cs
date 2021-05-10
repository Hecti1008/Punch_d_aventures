using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoCubo : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            Debug.Log("Daño Jugador");
            collision.transform.GetComponent<PlayerRespawn>().Playerdamaged();
        }
    }
}

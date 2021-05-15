using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LlaveManagerFinal : MonoBehaviour
{
    private void Update()
    {
        AllLlavesCollected();
    }
    public void AllLlavesCollected()
    {
        if (transform.childCount == 0)
        {
            Debug.Log("No quedan Llaves, VICTORIA");
            SceneManager.LoadScene("Creditos");
        }
    }
}

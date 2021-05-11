using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LlaveManager : MonoBehaviour
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
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}

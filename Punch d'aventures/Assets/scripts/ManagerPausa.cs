using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerPausa : MonoBehaviour
{
    public GameObject pauseMenu;

    public void pauseButton()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }

    public void playButton()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

    public void menuButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Jugar");
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            pauseButton();
        }
    }
}

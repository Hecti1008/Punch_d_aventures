using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRespawn : MonoBehaviour
{

    private float checkPointPositionX, checkPointPositionY;
    public Animator animatior;


    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetFloat("checkPointPositionX")!=0)
        {
            transform.position = (new Vector2(PlayerPrefs.GetFloat("checkPointPositionX"), PlayerPrefs.GetFloat("checkPointPositionY")));
        }
    }

    // Update is called once per frame
    public void ReachedCheckpoint(float X, float Y)
    {
        PlayerPrefs.SetFloat("checkPointPositionX", X);
        PlayerPrefs.SetFloat("checkPointPositionY", Y);

    }

    public void Playerdamaged()
    {
        animatior.Play("hit");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

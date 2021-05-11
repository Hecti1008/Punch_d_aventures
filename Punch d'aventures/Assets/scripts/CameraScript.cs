using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject punch;
    void Update()
    {
        if (punch != null)
        {
            Vector3 position = transform.position;
            position.x = punch.transform.position.x;
            position.y = punch.transform.position.y;
            transform.position = position;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kijken : MonoBehaviour {

    public Vector3 bodyx;
    public Vector3 camx;
    public GameObject cam;
    public GameObject body;



    void Update()
    {
        camx.x = -Input.GetAxis("Mouse Y");
        {
            cam.transform.Rotate(camx);
        }
        bodyx.y = Input.GetAxis("Mouse X");
        {
            body.transform.Rotate(bodyx);
        }

    }
}

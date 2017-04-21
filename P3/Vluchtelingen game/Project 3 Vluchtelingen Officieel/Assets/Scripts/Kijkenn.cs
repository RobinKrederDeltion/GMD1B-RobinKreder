using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kijkenn : MonoBehaviour {

    public Vector3 lichaamx;
    public Vector3 camx;
    public GameObject lichaam;
    public GameObject cam;


    //Hiermee kun je om je heen kijken.
    void Update()
    {
        camx.x = -Input.GetAxis("Mouse Y");
        {
            cam.transform.Rotate(camx);
        }
        lichaamx.y = Input.GetAxis("Mouse X");
        {
            lichaam.transform.Rotate(lichaamx);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lopen : MonoBehaviour {

    public Vector3 A;
    public float ver;
    public float hor;
    public float speed;


   

    // Update is called once per frame
    void FixedUpdate()
    {
        ver = Input.GetAxis("Vertical");
        hor = Input.GetAxis("Horizontal");

        A.z = ver;
        A.x = hor;


        transform.Translate(A * Time.deltaTime * speed);

    }
}

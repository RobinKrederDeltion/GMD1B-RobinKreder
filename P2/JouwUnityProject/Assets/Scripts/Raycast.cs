using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour {

    private RaycastHit hit;
    public float length;
    public Animation open;
    public bool fenceIsOpen;

    void Update()
    {
        Debug.DrawRay(transform.position, Vector3.forward, Color.blue, length);
        if (Physics.Raycast(transform.position, Vector3.forward, out hit, length))
        {
            if (hit.collider.tag == "fence")
            {
                if (fenceIsOpen == false)
                {
                    open.Play();
                    fenceIsOpen = true;
                }
            }
        }



    }
}

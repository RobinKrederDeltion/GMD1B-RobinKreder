using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LopenEnRennen : MonoBehaviour
{

    public int speed;
    public Vector3 a;
    public float hor;
    public float ver;

    // Lopen
    public void FixedUpdate()
    {
        ver = Input.GetAxis("Vertical");
        hor = Input.GetAxis("Horizontal");

        a.z = ver;
        a.x = hor;

        transform.Translate(a * Time.deltaTime * speed);
    }

    //Hiermee kun je een water bottle van de grond oppakken en daardoor krijg je extra speed.
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Water") 
        {
            speed = 10;
            col.gameObject.SetActive(false); //hierdoor verdwijnt het object als je het aangeraakt hebt.
        }
    }
}

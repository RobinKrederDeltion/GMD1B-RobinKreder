﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PickupObject : MonoBehaviour {
	GameObject mainCamera;
	bool carrying;
	GameObject carriedObject;
	public float distance;
	public float smooth;
    public RaycastHit ray;
    public Vector3 target;
    public GameObject doel;

	void Start ()
    {
       
		mainCamera = GameObject.FindWithTag("MainCamera");
        target = doel.transform.position;
	}
	
	
	void FixedUpdate ()
    {
        
		if(carrying) {
			carry(carriedObject);
			checkDrop();
			
		} else {
			pickup();
		}
	}

	void rotateObject()
    {
        transform.LookAt(target);
		carriedObject.transform.Rotate(5,10,15);
	}

	void carry(GameObject o)
    {
    .
		o.transform.position = Vector3.Lerp (o.transform.position, mainCamera.transform.position + mainCamera.transform.forward * distance, Time.deltaTime * smooth);
		o.transform.rotation = Quaternion.identity;
    }

	void pickup()
    {
        
		if(Input.GetButtonDown("E")) 
            {
			int x = Screen.width / 2;
			int y = Screen.height / 2;

       
			Ray ray = mainCamera.GetComponent<Camera>().ScreenPointToRay(new Vector3(x,y));
			RaycastHit hit;
			if(Physics.Raycast(ray, out hit)) {
				Pickupable p = hit.collider.GetComponent<Pickupable>();
				if(p != null) {
					carrying = true;
					carriedObject = p.gameObject;
				
					p.gameObject.GetComponent<Rigidbody>().useGravity = false;
				}
			}
		}
	}

	void checkDrop()
    {
		if(Input.GetButtonDown ("E"))
        {
			dropObject();
		}
	}

	void dropObject()
    {
		carrying = false;
		
		carriedObject.gameObject.GetComponent<Rigidbody>().useGravity = true;
		carriedObject = null;
	}
}
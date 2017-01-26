using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kasteelscore : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    void OnCollisionEnter(Collision Collision)
    {


        GameObject.Find("GameManager").GetComponent<GameData>().score += 30;

    }
}

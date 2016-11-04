using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public Rigidbody bal;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision Collision)
    {
        

        GameObject.Find("GameManager").GetComponent<GameManager>().score += 10;
        
    }
}

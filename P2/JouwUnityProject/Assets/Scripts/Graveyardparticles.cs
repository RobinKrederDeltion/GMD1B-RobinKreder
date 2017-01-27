using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graveyardparticles : MonoBehaviour {
    private RaycastHit hit;
    public float range;
    public List<ParticleSystem> particles = new List<ParticleSystem>();
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Physics.Raycast(transform.position, transform.forward, out hit, range))
        {
            if (hit.collider.tag == "Player")
            {
                for (int i = 0; i<particles.Count; i++)
                {
                    particles[i].Play();
                }
            }
        }
	}
}

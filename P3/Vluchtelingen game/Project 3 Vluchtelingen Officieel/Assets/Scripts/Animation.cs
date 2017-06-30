using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour {

    public Animator anim;

	void Start () {
        anim = GetComponent<Animator>();
	}

	void Update () {
        if (Input.GetKeyDown("w"))
        {
            anim.Play("Lopen");
        }
        else anim.Play("Idle");    
	}
}

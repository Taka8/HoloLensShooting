﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PA_DroneMove : MonoBehaviour {
	void Update(){
        //transform.position = new Vector3 (transform.position.x, Mathf.PingPong (Time.time,0.03f)+2, transform.position.z);
        transform.position = new Vector3(transform.position.x,transform.position.y, transform.position.z);
        
    }
    private Animator animator;


    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
    }

}

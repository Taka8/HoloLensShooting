using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PA_DroneMove : MonoBehaviour {

	private float x;
	private Animator animator;

	// Use this for initialization
	void Start () { 
		animator = GetComponent<Animator>();
		x =Random.Range(3.0f,5.0f);
	}


	void Update(){
		
        //transform.position = new Vector3 (transform.position.x, Mathf.PingPong (Time.time,0.03f)+2, transform.position.z);
		//transform.position = new Vector3 (transform.position.x,transform.position.y, transform.position.z);

		transform.position = new Vector3 (transform.position.x, Mathf.PingPong (Time.time,0.03f)+x, transform.position.z);
        
    }
   


   
}

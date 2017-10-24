using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PA_DroneMove : MonoBehaviour {

	public Transform target;

	private Animator animator;

	void Update(){
		transform.position = new Vector3 (transform.position.x, Mathf.PingPong (Time.time,0.03f)+2, transform.position.z);
	}


    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();

		transform.LookAt (target);

    }

}

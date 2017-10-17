using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class TankBullet : MonoBehaviour {
    public float velocity = 10f;
    // Use this for initialization
    void Start () {
        GetComponent<Rigidbody>().velocity = transform.forward * velocity;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

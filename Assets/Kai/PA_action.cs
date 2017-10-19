using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PA_action : MonoBehaviour {
    public Transform target;
    public float rotMax;
    public int score;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 vec = target.position - transform.position;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(new Vector3(vec.x, vec.y, vec.z)), rotMax);
    
}
 
    
   
}

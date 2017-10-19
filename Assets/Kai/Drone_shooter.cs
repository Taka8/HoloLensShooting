using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drone_shooter : MonoBehaviour {
    public float timeOut;
    private float timeElapsed;
    public TankBullet bullet;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timeElapsed += Time.deltaTime;
        if (timeElapsed >= timeOut)
        {
            Instantiate(bullet, transform.position, transform.rotation);
            timeElapsed = 0.0f;

        }
    }
}

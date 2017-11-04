using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour {

	public float setShakeTIme; // 持続振動時間

	private float lifeTime;
	private Vector3 savePosition;
	private float lowRangeX;
	private float maxRangeX;
	private float lowRangeY; 
	private float maxRangeY;

	void CatchShake() {
		savePosition = GameObject.Find ("Main Camera").transform.position;
		lowRangeY = savePosition.y - 1.0f;
		maxRangeY = savePosition.y + 1.0f;
		lowRangeX = savePosition.x - 1.0f;
		maxRangeX = savePosition.x + 1.0f;
		lifeTime = setShakeTIme;
	}

	// Use this for initialization
	void Start () {
		if(setShakeTIme <= 0.0f)
			setShakeTIme = 0.7f;
		lifeTime = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		if(lifeTime < 0.0f){
			GameObject.Find ("Main Camera").transform.position = savePosition;
			lifeTime = 0.0f;
		}

		if(lifeTime > 0.0f){
			lifeTime -= Time.deltaTime;
			float x_val = Random.Range(lowRangeX,maxRangeX);
			float y_val = Random.Range(lowRangeY,maxRangeY);
			GameObject.Find ("Main Camera").transform.position = new Vector3(x_val,y_val,transform.position.z);
		}


	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.GetComponent<Enemy>() || other.GetComponent<DroneBullet>())
		{
			CatchShake();
		}
	}
}

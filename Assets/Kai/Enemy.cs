using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	public GameObject explosion;    //爆発エフェクト
	private bool isQuitting = false;
    private static float score = 10f;
    void Update()
    {
        Invoke("Stop", 60f);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerBullet>())
        {
            Destroy(gameObject);
			Data data = new Data ();
			data.AddScore ((int)score);
           
        }
      
    }
    void OnApplicationQuit() {
        isQuitting = true;
    }
	void OnDestroy () {
		        if(!isQuitting){
			            GameObject.Instantiate(explosion, transform.position, Quaternion.identity);
			        }
		    }
   

}


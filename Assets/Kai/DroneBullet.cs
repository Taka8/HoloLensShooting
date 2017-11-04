using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class DroneBullet : MonoBehaviour {
    public float velocity = 10f;
    public float bullet = 10f;
	public GameObject explosion;    //爆発エフェクト
	private  static bool  isQuitting = false;

    // Use this for initialization
    void Start () {
        GetComponent<Rigidbody>().velocity = transform.forward * velocity;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.tag == "Player")
        {
            //プレイヤーと衝突した時
            other.gameObject.SendMessage("Damage", bullet);
			Destroy(gameObject);
        }

		if (other.GetComponent<PlayerBullet>())
		{
			Destroy(gameObject);
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

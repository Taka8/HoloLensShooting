using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class TankBullet : MonoBehaviour {
    public float velocity = 10f;
    public float bullet = 10f;
    // Use this for initialization
    void Start () {
        GetComponent<Rigidbody>().velocity = transform.forward * velocity;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider Player)
    {
       
        if (Player.gameObject.tag == "Player")
        {
            //プレイヤーと衝突した時
            Player.gameObject.SendMessage("Damage", bullet);
        }
      
    }
   

}

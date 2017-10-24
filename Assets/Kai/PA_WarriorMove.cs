using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PA_WarriorMove : MonoBehaviour {

	public Transform target;    //targetを代入
	    public float speed = 3; //移動速度
	    // Use this for initialization
	    void Start () {
		      target   = GameObject.FindGameObjectWithTag("Target").transform;
		    }
	     
	    // Update is called once per frame
	    void Update () {
		        Vector3 targetPos = target.position;    //プレイヤーの位置
		        Vector3 direction = targetPos - transform.position; //方向
		        direction = direction.normalized;   //単位化（距離要素を取り除く）
		        transform.position = transform.position + (direction * speed * Time.deltaTime);
		        transform.LookAt(target);   //プレイヤーの方を向く
		    }

}

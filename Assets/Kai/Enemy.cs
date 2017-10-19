using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    private float score = 10f;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerBullet>())
        {
            Destroy(gameObject);
            GameObject.Find("Score").SendMessage("AddScore", score);

        }
      
    }

}


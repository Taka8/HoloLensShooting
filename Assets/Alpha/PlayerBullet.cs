using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerBullet : MonoBehaviour
{

    public float velocity=10f;

    void Start()
    {
        GetComponent<Rigidbody>().velocity = transform.forward * velocity;

        Destroy(gameObject, 10f);
    }

    void Update()
    {

    }
}

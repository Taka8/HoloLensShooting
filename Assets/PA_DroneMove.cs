using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PA_DroneMove : MonoBehaviour {
    private Animator animator;
    int x=0;

    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update () {
        while (x==0) {
            animator.SetBool("Idol", true);

        }
    }
}

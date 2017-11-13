using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeUpScript : MonoBehaviour
{
    static Text text;
    private float time = 60;

    // Use this for initialization
    public void Start()
    {
       


    }
   
       
   
    // Update is called once per frame
    public void Update()
    {
        time -= Time.deltaTime;
        if (time < 0)
        {
            Debug.Log(name + " update.");
            time = 0;
            Enemy enemy = GetComponent<Enemy>();
            DroneBullet dronebullet = GetComponent<DroneBullet>();
            SceneManager.LoadScene("Clear");


        }
    }
}




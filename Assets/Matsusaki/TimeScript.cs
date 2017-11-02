using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeScript : MonoBehaviour {
    private float time = 60;
   
    
	// Use this for initialization
	void Start () {
        GetComponent<Text>().text = ((int)time).ToString();
	}
	
	// Update is called once per frame
	public void  Update () {
       
        time -= Time.deltaTime;

        if (time < 0) {
            
            time = 0;
           

        }
        GetComponent<Text>().text = "Time:"+((int)time).ToString();	
	}
   


}

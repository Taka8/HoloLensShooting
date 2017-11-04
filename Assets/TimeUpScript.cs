using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public  class TimeUpScript : MonoBehaviour {
    static Text text;
    private float time = 5;
   
    // Use this for initialization
    public void  Start () {
        GetComponent<Text>().text = "TIME UP".ToString();
        this.gameObject.GetComponent<Text>().enabled = false;
       
       
	}
    

    // Update is called once per frame
    public void Update () {
          time -= Time.deltaTime;
       
        if (time < 0)
        {
            this.gameObject.GetComponent<Text>().enabled = true;
            time = 0;
            Time.timeScale = 0;
             

        }
          
        }
    }
   



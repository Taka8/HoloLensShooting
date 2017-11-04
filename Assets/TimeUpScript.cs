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
        GetComponent<Text>().text = "TIME UP".ToString();
        this.gameObject.GetComponent<Text>().enabled = false;


    }
    public void ReLoad()
    {
        SceneManager.LoadScene("shooting");
    }
    // Update is called once per frame
    public void Update()
    {
        time -= Time.deltaTime;
        if (time < 0)
        {
            Debug.Log(name + " update.");
            this.gameObject.GetComponent<Text>().enabled = true;
            
            time = 0;
            Time.timeScale = 0;

        }
    }
}




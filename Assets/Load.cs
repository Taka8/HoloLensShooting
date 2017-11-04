using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Load : MonoBehaviour {
    GameObject button;
  
    public void SceneLoad()
    {
        SceneManager.LoadScene("shooting");
    }
    // Use this for initialization
    void Start () {
        button = GameObject.Find("Canvas/Button");
            
            button.SetActive(true);
        
    }
	
	// Update is called once per frame
	void Update () {
       
	}
}

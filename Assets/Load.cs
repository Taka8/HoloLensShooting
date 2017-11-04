using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Load : MonoBehaviour {
    GameObject button;
    private float time = 60;
    public void SceneLoad()
    {
        SceneManager.LoadScene("shooting");
    }
    // Use this for initialization
    void Start () {
        button = GameObject.Find("Canvas/Button");
        button.SetActive(false);
        time -= Time.deltaTime;
    }
	
	// Update is called once per frame
	void Update () {
        if (time == 0) {
            button.SetActive(true);
        }
	}
}

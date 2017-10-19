using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour {
    private int score;
    public Text text;

    // Use this for initialization
    void Start () {
      
        
        this.score = 0;
    }
    void AddScore(int score) {
        this.score += score;
    }
    
	// Update is called once per frame
	void Update () {
        text.text = "Score:" + this.score;
    }
    
}

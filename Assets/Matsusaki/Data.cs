using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Data : MonoBehaviour {
    public readonly static Data Instance = new Data();
    public Text text;
    public int score = 0;
	// Use this for initialization
	void Start () {
        Data.Instance.score = 0;
	}
    public void AddScore(int score)
    {
        Data.Instance.score += score;
    }
    // Update is called once per frame
    void Update () {

        text.text = "Score:" + Data.Instance.score;
    }
   
}

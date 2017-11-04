using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour {

	public Texture2D image;
	private float xMin;
	private float yMin;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnGUI()
	{
		//xMin = Screen.width - (Screen.width - Input.mousePosition.x) - (image.width / 2);
		//yMin = (Screen.height - Input.mousePosition.y) - (image.height / 2);
		//GUI.DrawTexture (new Rect (xMin, yMin, image.width, image.height), image);
		GUI.DrawTexture (new Rect (660,385, 128, 64), image);
	}
}

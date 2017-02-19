using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class ShowButton : MonoBehaviour {

	public Canvas marsCanvas;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		enableCanvas ();
	}

	public void enableCanvas()
	{
		if (Time.fixedTime > 5) {
			marsCanvas.gameObject.SetActive(true);
		}
	}
}

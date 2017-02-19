using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.VR;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {

	public Canvas marsCanvas; 
	public Image questionPanel;
	public Image successPanel; 
	public Image failurePanel; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void onCorrectButtonClicked(){
		
		questionPanel.gameObject.SetActive (false);

		//Show green panel with correct 
		if (Time.fixedTime < 10) {
			successPanel.color = Color.green; 
			successPanel.gameObject.SetActive (true); 

		}

		//Transition to next question and scene: 
	}

	public void onOtherButtonClicked(){
		questionPanel.gameObject.SetActive (false);

		//Show red panel with incorrect
		StartCoroutine(loadSceneWithName());
	}

	public IEnumerator loadSceneWithName() {
		failurePanel.color = Color.red; 
		failurePanel.gameObject.SetActive (true); 
		yield return new WaitForSeconds (10);
		SceneManager.LoadScene ("FieldScene");
	}
}


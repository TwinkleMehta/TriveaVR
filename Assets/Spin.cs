using UnityEngine;
using System.Collections;

public class Spin : MonoBehaviour {

	public float degreesPerSecond;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.up * Time.deltaTime * degreesPerSecond);
	
	}
}

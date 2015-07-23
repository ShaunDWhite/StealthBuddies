using UnityEngine;
using System.Collections;

public class s_CameraOn : MonoBehaviour {

	public bool IsOn = true;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log("IsOn = " + IsOn);	
	}
}

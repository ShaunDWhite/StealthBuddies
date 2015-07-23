﻿using UnityEngine;
using System.Collections;

public class s_CameraOff : MonoBehaviour {

	public s_CameraOn CameraOn;
	public float Timer = 5;

	void OnTriggerEnter(Collider col){
		if(col.gameObject.name == "Player One"){
			Debug.Log("le button is pressed, timer starts");
			StartCoroutine(CameraOff());
		}
		else if(col.gameObject.name == "Player Two"){
			Debug.Log("le button is pressed, timer starts");
			StartCoroutine(CameraOff());
		}
	}

	public IEnumerator CameraOff(){
		CameraOn.IsOn = false;				//deactivates camera
		yield return new WaitForSeconds(Timer);	//waits 5 seconds
		CameraOn.IsOn = true;				//camera comes back on 
		Debug.Log("Le timer is finished");
	}
}

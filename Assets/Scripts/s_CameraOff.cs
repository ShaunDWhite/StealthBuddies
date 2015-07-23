using UnityEngine;
using System.Collections;

public class s_CameraOff : MonoBehaviour {

	public s_CameraOn CameraOn;

	void OnTriggerEnter(Collider col){
		if(col.gameObject.name == "Player One"){
			Debug.Log("le button is pressed, timer starts");
			StartCoroutine(CameraOff());
		}
	}

	public IEnumerator CameraOff(){
		CameraOn.IsOn = false;				//deactivates camera
		yield return new WaitForSeconds(5);	//waits 5 seconds
		CameraOn.IsOn = true;				//camera comes back on 
		Debug.Log("Le timer is finished");
	}
}

using UnityEngine;
using System.Collections;

public class s_CameraOff : MonoBehaviour {

	public s_CameraOn CameraOne, CameraTwo;
	public float Timer = 5;

	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.name == "PlayerOneTest"){
			Debug.Log("le button is pressed, timer starts");
			StartCoroutine(CameraOneOff());
		}
		else if(col.gameObject.name == "PlayerTwoTest"){
			Debug.Log("le Camers 2 button is pressed, timer starts");
			StartCoroutine(CameraTwoOff());
		}
	}

	public IEnumerator CameraOneOff(){
		CameraOne.IsOn = false;				//deactivates camera
		yield return new WaitForSeconds(Timer);	//waits 5 seconds
		CameraOne.IsOn = true;				//camera comes back on 
		Debug.Log("Le timer is finished");
	}

	public IEnumerator CameraTwoOff(){
		CameraTwo.IsOn = false;				//deactivates camera
		yield return new WaitForSeconds(Timer);	//waits 5 seconds
		CameraTwo.IsOn = true;				//camera comes back on 
		Debug.Log("Le Camera 2 timer is finished");
	}

}

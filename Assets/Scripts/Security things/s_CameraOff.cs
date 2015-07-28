using UnityEngine;
using System.Collections;


public class s_CameraOff : MonoBehaviour {

	public s_CameraOn CameraOne, CameraTwo;
	public float Timer = 5;
	public bool P1_Press = false, 
				P2_Press = false;

//	void OnTriggerEnter2D(Collider2D col){
//		if(col.gameObject.name == "PlayerOneTest"){
//			Debug.Log("le button is pressed, timer starts");
//			StartCoroutine(CameraOneOff());
//		}
//		else if(col.gameObject.name == "PlayerTwoTest"){
//			Debug.Log("le Camers 2 button is pressed, timer starts");
//			StartCoroutine(CameraTwoOff());
//		}
//	}

	public IEnumerator CameraOneOff(){
		CameraOne.IsOn = false;			
		yield return new WaitForSeconds(Timer);
		CameraOne.IsOn = true;
	}

	public IEnumerator CameraTwoOff(){
		CameraTwo.IsOn = false;				//deactivates camera
		yield return new WaitForSeconds(Timer);	//waits 5 seconds
		CameraTwo.IsOn = true;				//camera comes back on 
	}



	void Update(){
//		if (P1_Press) {
//			if(Input.GetKeyDown(KeyCode.Space)){
//				StartCoroutine(CameraOneOff());
//			}
//		}
		if (P2_Press) {
			if(Input.GetKeyDown(KeyCode.Space)){
				StartCoroutine(CameraTwoOff());
			}
		}
	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.name == "PlayerOneTest"){
			Debug.Log("le button is pressed, timer starts");
			P1_Press = true;
		}
		else if(col.gameObject.name == "PlayerTwoTest"){
			Debug.Log("le Camers 2 button is pressed, timer starts");
			P2_Press = true;
		}
	}

	void OnTriggerExit2D(Collider2D col){
		if(col.gameObject.name == "PlayerOneTest"){
			P1_Press = false;
		}
		else if(col.gameObject.name == "PlayerTwoTest"){
			P2_Press = false;
		}
	}



}
using UnityEngine;
using System.Collections;


public class s_CameraOff : MonoBehaviour {

	public s_CameraOn CameraOne, CameraTwo;
	public float Timer = 1.5f;
	public bool P1_Press = false, 
				P2_Press = false;
	public s_GameManager gameManager;


	public void Start(){
		gameManager = GameObject.Find ("GameManager").GetComponent<s_GameManager> ();
	}


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
		if (P1_Press) {
			if(Input.GetButtonDown("A")){
				gameManager.ButtonAudio();
				StartCoroutine(CameraOneOff());
			}
		}
		if (P2_Press) {
			if(Input.GetKeyDown(KeyCode.Space)){
				if(Application.loadedLevelName == "Level_4"){
					gameManager.ButtonAudio();
					StartCoroutine(CameraOneOff());
					StartCoroutine(CameraTwoOff());
				}
				else {
					gameManager.ButtonAudio();
					StartCoroutine(CameraTwoOff());
				}
			}
		}
	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.name == "PlayerOneTest"){
			P1_Press = true;
		}
		else if(col.gameObject.name == "PlayerTwoTest"){
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
using UnityEngine;
using System.Collections;

public class s_CameraOn : MonoBehaviour {

	public bool IsOn = true;
	public float alarmTime = 3;
	public string player;
	public s_GameManager gameManager;
	
		
	// Use this for initialization
	void Start () {
		gameManager = GameObject.Find ("GameManager").GetComponent<s_GameManager> ();
	}


	void OnTriggerEnter2D(Collider2D col){					
		if(col.gameObject.name == "PlayerOneTest"){				
			if(IsOn){
				gameManager.P1_Detected = true;
				gameManager.ElectronicAudio();
				gameManager.Detected("camera", 1, transform.position); //Metrics Edit
			}
		}
		else if(col.gameObject.name == "PlayerTwoTest"){		
			if(IsOn){
				gameManager.P2_Detected = true;
				gameManager.ElectronicAudio();
				gameManager.Detected("camera", 2, transform.position); //Metrics Edit
			}
		}
	}


	void OnTriggerStay2D(Collider2D col){
		if(col.gameObject.name == "PlayerTwoTest"){
			if(IsOn){
				gameManager.P2_Detected = true;
				gameManager.ElectronicAudio();
				gameManager.Detected("camera", 2, transform.position); //Metrics Edit
			}
		}
		else if(col.gameObject.name == "PlayerOneTest"){
			if(IsOn){
				gameManager.P1_Detected = true;
				gameManager.ElectronicAudio();
				gameManager.Detected("camera", 1, transform.position); //Metrics Edit
			}
		}
	}
}

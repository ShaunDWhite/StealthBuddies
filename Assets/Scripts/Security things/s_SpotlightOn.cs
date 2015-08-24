using UnityEngine;
using System.Collections;

public class s_SpotlightOn : MonoBehaviour {

	public bool LightIsOn = true;
	public s_GameManager gameManager;


	void Start(){
		gameManager = GameObject.Find ("GameManager").GetComponent<s_GameManager> ();
	}


	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.name == "PlayerOneTest"){				
			if(LightIsOn){
				gameManager.P1_Detected = true;
				gameManager.ElectronicAudio();
				gameManager.Detected("spotlight", 1, transform.position); //Metrics Edit.
			}
		}
		else if(col.gameObject.name == "PlayerTwoTest"){		
			if(LightIsOn){
				gameManager.P2_Detected = true;
				gameManager.ElectronicAudio();
				gameManager.Detected("spotlight", 2, transform.position); //Metrics Edit.
			}
		}
	}

	void OnTriggerStay2D(Collider2D col){
		if(col.gameObject.name == "PlayerTwoTest"){
			if(LightIsOn){
				gameManager.P2_Detected = true;
				gameManager.ElectronicAudio();
				gameManager.Detected("spotlight", 2, transform.position); //Metrics Edit.
			}
		}
		else if(col.gameObject.name == "PlayerOneTest"){
			if(LightIsOn){
				gameManager.P1_Detected = true;
				gameManager.ElectronicAudio();
				gameManager.Detected("spotlight", 1, transform.position); //Metrics Edit.
			}
		}
	}
}

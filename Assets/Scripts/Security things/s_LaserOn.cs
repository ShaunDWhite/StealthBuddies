using UnityEngine;
using System.Collections;

public class s_LaserOn : MonoBehaviour {

	public bool IsTurnedOn = true;
	public s_GameManager gameManager;
	
	
	// Use this for initialization
	void Start () {
		gameManager = GameObject.Find ("GameManager").GetComponent<s_GameManager> ();
	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.name == "PlayerOneTest"){						
			if(IsTurnedOn){	
				gameManager.LaserAudio();
				gameManager.P1_Detected = true;
				gameManager.Detected("laser", 1, transform.position); //Metrics Edit
			}
		}
		else if(col.gameObject.name == "PlayerTwoTest"){				
			if(IsTurnedOn){
				gameManager.P2_Detected = true;
				gameManager.LaserAudio();
				gameManager.Detected("laser", 2, transform.position); //Metrics Edit
			}
		}
	}
}

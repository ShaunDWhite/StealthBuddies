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
		if(col.gameObject.name == "PlayerOneTest"){				//if player one
			if(IsOn){											// if turned on
				gameManager.Detected();
			}
			else if(!IsOn){										// if turned off
				Debug.Log("p1 no alarm");						// no alarm
			}
		}
		else if(col.gameObject.name == "PlayerTwoTest"){		// if player 2
			if(IsOn){											// if turned on
				gameManager.Detected();
			}
			else if(!IsOn){										//if turned off
				Debug.Log("p2 no alarm");						// no alarm
			}
		}
	}
}

using UnityEngine;
using System.Collections;

public class s_SpotlightOn : MonoBehaviour {

	public bool LightIsOn = true;
	public s_GameManager gameManager;


	void Start(){
		gameManager = GameObject.Find ("GameManager").GetComponent<s_GameManager> ();
	}


	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.name == "PlayerOneTest"){				//If player one
			if(LightIsOn){										// if it's turned on
				gameManager.Detected();
			}
			else if(!LightIsOn){								//If turned off
				Debug.Log("p1 no alarm");						// no alarm
			}
		}
		else if(col.gameObject.name == "PlayerTwoTest"){		//if player 2
			if(LightIsOn){										//if its turned on			
				gameManager.Detected();
			}
			else if(!LightIsOn){								// if turned off
				Debug.Log("p2 no alarm");						// no alarm
			}
		}
	}
}

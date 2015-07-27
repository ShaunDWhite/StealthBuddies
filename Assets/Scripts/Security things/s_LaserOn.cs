using UnityEngine;
using System.Collections;

public class s_LaserOn : MonoBehaviour {

	public bool IsTurnedOn = true;


	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.name == "PlayerOneTest"){
			if(IsTurnedOn){
				Debug.Log("P1 alarm");
			}
			else if(!IsTurnedOn){
				Debug.Log("P1 no alarm");
			}
		}
		else if(col.gameObject.name == "PlayerTwoTest"){
			if(IsTurnedOn){
				Debug.Log("P2 alarm");
			}
			else if(!IsTurnedOn){
				Debug.Log("P2 no alarm");
			}
		}
	}
}

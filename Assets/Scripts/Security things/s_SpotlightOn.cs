using UnityEngine;
using System.Collections;

public class s_SpotlightOn : MonoBehaviour {

	public bool LightIsOn = true;


	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.name == "PlayerOneTest"){
			if(LightIsOn){
				Debug.Log("p1 alarm");
			}
			else if(!LightIsOn){
				Debug.Log("p1 no alarm");
			}
		}
		else if(col.gameObject.name == "PlayerTwoTest"){
			if(LightIsOn){
				Debug.Log("p2 alarm");
			}
			else if(!LightIsOn){
				Debug.Log("p2 no alarm");
			}
		}
	}
}

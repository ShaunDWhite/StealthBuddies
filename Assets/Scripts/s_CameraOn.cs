using UnityEngine;
using System.Collections;

public class s_CameraOn : MonoBehaviour {

	public bool IsOn = true;

	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.name == "PlayerOneTest"){
			if(IsOn){
				Debug.Log("p1 alarm");
			}
			else if(!IsOn){
				Debug.Log("p1 no alarm");
			}
		}
		else if(col.gameObject.name == "PlayerTwoTest"){
			if(IsOn){
				Debug.Log("p2 alarm");
			}
			else if(!IsOn){
				Debug.Log("p2 no alarm");
			}
		}
	}
}

using UnityEngine;
using System.Collections;

public class s_CameraOn : MonoBehaviour {

	public bool IsOn = true;

	
	// Update is called once per frame
	void Update () {
		Debug.Log("IsOn = " + IsOn);	
	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.name == "PlayerTwoTest"){
			if(IsOn){
				Debug.Log("alarm");
			}
			else if(!IsOn){
				Debug.Log("no alarm");
			}
		}
	}
}

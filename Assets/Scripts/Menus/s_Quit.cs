using UnityEngine;
using System.Collections;

public class s_Quit : MonoBehaviour {

	void Update(){
		if(Input.GetKey(KeyCode.Escape)){
			Application.LoadLevel("MainMenu");
		}
	}
}

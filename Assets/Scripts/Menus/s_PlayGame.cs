using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class s_PlayGame : MonoBehaviour {

	public void Yup(){
		Application.LoadLevel("Level_1_Test");
	}

	void OnMouseDown(){
		if(gameObject.name == "Play"){
			Yup();
		}
	}
}

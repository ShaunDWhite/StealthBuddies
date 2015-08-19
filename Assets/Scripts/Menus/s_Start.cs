using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class s_Start : MonoBehaviour {

	public void Yay(){
		CobaltMetrics.Metrics.StartMetrics ("7bd602166979f7b86a56b08551daa641"); //Metrics
		Application.LoadLevel("Controlls");
	}

	void OnMouseDown(){
		if(gameObject.name == "Play"){
			Yay ();
		}
	}
}

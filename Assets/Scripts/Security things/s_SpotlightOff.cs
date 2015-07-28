using UnityEngine;
using System.Collections;

public class s_SpotlightOff : MonoBehaviour {

	public s_SpotlightOn LightOne, LightTwo;
	public float Timer = 5;
	public bool P2_Press = false;

	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.name == "PlayerTwoTest"){
			StartCoroutine(LightOff ());
		}
	}


	void OnTriggerStay2D(Collider2D col){

		}

	public IEnumerator LightOff(){
		LightOne.LightIsOn = false;
		LightTwo.LightIsOn = false;
		yield return new WaitForSeconds(Timer);
		LightOne.LightIsOn = true;
		LightTwo.LightIsOn = true;
	}
}

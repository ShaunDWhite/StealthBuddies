using UnityEngine;
using System.Collections;

public class s_SpotlightOff : MonoBehaviour {

	public s_SpotlightOn LightOne, LightTwo;
	public float Timer = 5;

	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.name == "PlayerTwoTest"){
			StartCoroutine(LightOff ());
		}
	}

	public IEnumerator LightOff(){
		LightOne.LightIsOn = false;
		LightTwo.LightIsOn = false;
		yield return new WaitForSeconds(Timer);
		LightOne.LightIsOn = true;
		LightTwo.LightIsOn = true;
	}
}

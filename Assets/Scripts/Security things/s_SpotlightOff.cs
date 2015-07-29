using UnityEngine;
using System.Collections;

public class s_SpotlightOff : MonoBehaviour {

	public s_SpotlightOn LightOne, LightTwo;
	public float Timer = 1.5f;
	public bool P2_Press = false;
	public bool P1_Press = false;

	void OnTriggerStay2D(Collider2D col){
		if(col.gameObject.name == "PlayerTwoTest"){
			P2_Press = true;
		}
		else if(col.gameObject.name == "PlayerOneTest"){
			P1_Press = true;
		}
	}

	void OnTriggerExit2D(Collider2D col){
		if(col.gameObject.name == "PlayerTwoTest"){
			P2_Press = false;
		}
		else if(col.gameObject.name == "PlayerOneTest"){
			P1_Press = false;
		}
	}

	void Update(){
		if (P2_Press) {
			if(Input.GetKeyDown(KeyCode.Space)){
				StartCoroutine(LightOff ());
			}
		}
		if (P1_Press) {
			if(Input.GetButtonDown("A")){
				StartCoroutine(LightOff ());
			}
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

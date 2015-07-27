using UnityEngine;
using System.Collections;

public class s_CameraOn : MonoBehaviour {

	public bool IsOn = true;
	public float alarmTime = 3;
	public string player;
	public GameObject power, poweroff;

	void Start(){
		power.SetActive(true);
		poweroff.SetActive(false);
	}


	// Update is called once per frame
	void Update () {
		IsPower();
	}

	public void IsPower(){
		if(IsOn){
			power.SetActive(true);
			poweroff.SetActive(false);
		}

		if(!IsOn){
			power.SetActive(false);
			poweroff.SetActive(true);

		}
		

	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.name == "PlayerOneTest"){
			if(IsOn){
//				player = "Player one";
//				StartCoroutine(Alarm());
				Debug.Log("p1 alarm");
			}
			else if(!IsOn){
				Debug.Log("p1 no alarm");
			}
		}
		else if(col.gameObject.name == "PlayerTwoTest"){
			if(IsOn){
//				player = "Player two";
//				StartCoroutine(Alarm());
				Debug.Log("p2 alarm");
			}
			else if(!IsOn){
				Debug.Log("p2 no alarm");
			}
		}
	}

	public IEnumerator Alarm(){
		yield return new WaitForSeconds(alarmTime);
		Debug.Log(player + " alarm");
	}

}

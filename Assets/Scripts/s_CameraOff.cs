using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class s_CameraOff : MonoBehaviour {

	public s_CameraOn CameraOne, CameraTwo;
	public float Timer = 5;
	public Text TimeLeft;
	public int Dude;
	public int a;

	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.name == "PlayerOneTest"){
			Debug.Log("le button is pressed, timer starts");
			StartCoroutine(CameraOneOff());
		}
		else if(col.gameObject.name == "PlayerTwoTest"){
			Debug.Log("le Camers 2 button is pressed, timer starts");
			StartCoroutine(CameraTwoOff());
		}
	}

	public IEnumerator CameraOneOff(){
		CameraOne.IsOn = false;			
		yield return new WaitForSeconds(1);
		CameraOne.IsOn = true;	
		Debug.Log("Le timer is finished");
	}

	public IEnumerator CameraTwoOff(){
		CameraTwo.IsOn = false;				//deactivates camera
		yield return new WaitForSeconds(Timer);	//waits 5 seconds
		CameraTwo.IsOn = true;				//camera comes back on 
		Debug.Log("Le Camera 2 timer is finished");
	}



//	CameraOne.IsOn = false;
//	for(a = 0; a < 6; a++){		
//		yield return new WaitForSeconds(1);
//		Dude = (5 - a);
//		TimeLeft.text = "Time Left = " + Dude.ToString ();
//	}
//	CameraOne.IsOn = true;
//	a = 0;
//	TimeLeft.text = "Time Left = 5";
//	Debug.Log("Le timer is finished");




}

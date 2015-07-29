using UnityEngine;
using System.Collections;

public class s_Level3_Power : MonoBehaviour {

	public GameObject	
		CameraOne,
		LightOne,
		LightTwo,
		LightThree,
		LaserOne,
		LaserTwo,
		CameraCone,
		LightOneCone,
		LightTwoCone,
		LightThreeCone;
	public s_CameraOn C_One;
	public s_SpotlightOn S_One, S_Two;
	public s_LaserOn L_One;



	// Use this for initialization
	void Start () {
	
		LaserOne.SetActive(true);
		LaserTwo.SetActive(true);
		CameraCone.SetActive(true);
		LightOneCone.SetActive(true);
		LightTwoCone.SetActive(true);
		LightThreeCone.SetActive(true);

	}
	
	// Update is called once per frame
	void Update () {
		CameraPower();
		LaserPower();
		SingleLight();
		TwinLight();
	}


	void CameraPower(){
		if(C_One.IsOn){
			CameraCone.SetActive(true);
		}
		else if(!C_One.IsOn){
			CameraCone.SetActive(false);
		}
	}

	void LaserPower(){
		if(L_One.IsTurnedOn){
			LaserOne.SetActive(true);
			LaserTwo.SetActive(true);
		}
		else if(!L_One.IsTurnedOn){
			LaserOne.SetActive(false);
			LaserTwo.SetActive(false);
		}
	}

	void SingleLight(){
		if(S_Two.LightIsOn){
			LightThreeCone.SetActive(true);
		}
		else if(!S_Two.LightIsOn){
			LightThreeCone.SetActive(false);
		}
	}

	void TwinLight(){
		if(S_One.LightIsOn){
			LightOneCone.SetActive(true);
			LightTwoCone.SetActive(true);
		}
		else if(!S_One.LightIsOn){
			LightOneCone.SetActive(false);
			LightTwoCone.SetActive(false);
		}
	}
}

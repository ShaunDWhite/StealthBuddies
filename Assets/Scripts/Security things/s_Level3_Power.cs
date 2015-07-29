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



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		CameraPower();
		LaserPower();
		SingleLight();
		TwinLight();
	}


	void CameraPower(){

	}

	void LaserPower(){

	}

	void SingleLight(){

	}

	void TwinLight(){

	}
}

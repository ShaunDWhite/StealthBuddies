using UnityEngine;
using System.Collections;

public class s_Power : MonoBehaviour {


	public GameObject 
			PowerOn_Left,
			PowerOff_Left,
			PowerOn_Right,
			PowerOff_Right,
			PowerOn_Top,
			PowerOff_Top,
			PowerOn_Bottom,
			PowerOff_Bottom;
	public s_CameraOn CameraOne, CameraTwo;
	public s_SpotlightOn SpotLightOne, SpotLightTwo;


	// Use this for initialization
	void Start () {
		PowerOn_Left.SetActive(true);
		PowerOn_Right.SetActive(true);
		PowerOff_Left.SetActive(false);
		PowerOff_Right.SetActive(false);


	}
	
	// Update is called once per frame
	void Update () {	
		OneHasPower();
		TwoHasPower();
		TopHasPower();
		BottomHasPower();
	}


	public void OneHasPower(){
		if(CameraOne.IsOn){
			PowerOn_Left.SetActive(true);
			PowerOff_Left.SetActive(false);

		}
		else if(!CameraOne.IsOn){
			PowerOff_Left.SetActive(true);
			PowerOn_Left.SetActive(false);

		}
	}


	public void TwoHasPower(){
		if(CameraTwo.IsOn){
			PowerOn_Right.SetActive(true);
			PowerOff_Right.SetActive(false);
		}
		else if(!CameraTwo.IsOn){
			PowerOff_Right.SetActive(true);
			PowerOn_Right.SetActive(false);
		}
	}

	public void TopHasPower(){
		if(SpotLightOne.LightIsOn){
			PowerOn_Top.SetActive(true);
			PowerOff_Top.SetActive(false);
		}
		else if(!SpotLightOne.LightIsOn){
			PowerOn_Top.SetActive(false);
			PowerOff_Top.SetActive(true);
		}

	}

	public void BottomHasPower(){
		if(SpotLightTwo.LightIsOn){
			PowerOn_Bottom.SetActive(true);
			PowerOff_Bottom.SetActive(false);
		}
		else if(!SpotLightTwo.LightIsOn){
			PowerOn_Bottom.SetActive(false);
			PowerOff_Bottom.SetActive(true);
		}
	}




}

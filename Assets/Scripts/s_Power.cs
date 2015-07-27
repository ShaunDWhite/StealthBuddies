using UnityEngine;
using System.Collections;

public class s_Power : MonoBehaviour {


	public GameObject 
			PowerOn_Left,
			PowerOff_Left,
			PowerOn_Right,
			PowerOff_Right;
	public s_CameraOn CameraOne, CameraTwo;


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


}

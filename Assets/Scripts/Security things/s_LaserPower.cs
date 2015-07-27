using UnityEngine;
using System.Collections;

public class s_LaserPower : MonoBehaviour {

	public GameObject 			// On/off electricity signs for all 4 lasers
		L_TLOn, L_TLOff,  		//L_TLOn = Laser_TopLeftOn
		L_TROn, L_TROff, 		// And so on. I'll explain if this asked
		L_BLOn, L_BLOff,
		L_BROn, L_BROff;

	public GameObject L1, L2, L3, L4;

	public s_LaserOn L_One, L_Two, L_Three, L_Four;

	// Use this for initialization
	void Start () {	
		L_TLOn.SetActive(true);
		L_TROn.SetActive(true);
		L_BLOn.SetActive(true);
		L_BROn.SetActive(true);
		L_TLOff.SetActive(false);
		L_TROff.SetActive(false);
		L_BLOff.SetActive(false);
		L_BROff.SetActive(false);

		L1.SetActive(true);
		L2.SetActive(true);
		L3.SetActive(true);
		L4.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
		OneHasPower();
		TwoHasPower();
		ThreeHasPower();
		FourHasPower();
	}

	public void OneHasPower(){
		if(L_One.IsTurnedOn){
			L_TLOn.SetActive(true);
			L_TLOff.SetActive(false);
			L1.SetActive(true);
		}
		else if(!L_One.IsTurnedOn){
			L_TLOn.SetActive(false);
			L_TLOff.SetActive(true);
			L1.SetActive(false);
		}
	}

	public void TwoHasPower(){
		if(L_Two.IsTurnedOn){
			L_TROn.SetActive(true);
			L_TROff.SetActive(false);
			L2.SetActive(true);
		}
		else if(!L_Two.IsTurnedOn){
			L_TROn.SetActive(false);
			L_TROff.SetActive(true);
			L2.SetActive(false);
		}
	}
	public void ThreeHasPower(){
		if(L_Three.IsTurnedOn){
			L_BLOn.SetActive(true);
			L_BLOff.SetActive(false);
			L3.SetActive(true);
		}
		else if(!L_Three.IsTurnedOn){
			L_BLOn.SetActive(false);
			L_BLOff.SetActive(true);
			L3.SetActive(false);
		}
	}
	public void FourHasPower(){
		if(L_Four.IsTurnedOn){
			L_BROn.SetActive(true);
			L_BROff.SetActive(false);
			L4.SetActive(true);
		}
		else if(!L_Four.IsTurnedOn){
			L_BROn.SetActive(false);
			L_BROff.SetActive(true);
			L4.SetActive(false);
		}
	}

}

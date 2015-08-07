using UnityEngine;
using System.Collections;

public class s_Level4Power : MonoBehaviour {

	public GameObject L1, L2, L3_1, L3_2, L4;
	public s_LaserOn L_One, L_Two, L_Three_One, L_Three_Two, L_Four;


	// Use this for initialization
	void Start () {
		L1.SetActive(true);
		L2.SetActive(true);
		L3_1.SetActive(true);
		L3_2.SetActive(true);
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
			L1.SetActive(true);
		}
		else if(!L_One.IsTurnedOn){
			L1.SetActive(false);
		}
	}
	public void TwoHasPower(){
		if(L_Two.IsTurnedOn){
			L2.SetActive(true);
		}
		else if(!L_Two.IsTurnedOn){
			L2.SetActive(false);
		}
	}
	public void ThreeHasPower(){
		if((L_Three_One.IsTurnedOn) && (L_Three_Two.IsTurnedOn)){
			L3_1.SetActive(true);
			L3_2.SetActive(true);
		}
		if((!L_Three_One.IsTurnedOn) && (!L_Three_Two.IsTurnedOn)){
			L3_1.SetActive(false);
			L3_2.SetActive(false);
		}
	}
	public void FourHasPower(){
		if(L_Four.IsTurnedOn){
			L4.SetActive(true);
		}
		else if(!L_Four.IsTurnedOn){
			L4.SetActive(false);
		}
	}

}

using UnityEngine;
using System.Collections;

public class s_Level5Power : MonoBehaviour {

	public GameObject L1, L2;
	public s_LaserOn
		L_One, 
		L_Two;
		


	// Use this for initialization
	void Start () {
		L1.SetActive (true);
		L2.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
		One ();
		Two ();
	}


	public void One(){
		if (L_One.IsTurnedOn){
			L1.SetActive (true);
				}
		else if(!L_One.IsTurnedOn) {
			L1.SetActive (false);
		}
	}

	public void Two(){
		if (L_Two.IsTurnedOn) {
			L2.SetActive (true);
		}
		else if(!L_Two.IsTurnedOn){
			L2.SetActive (false);
		}
	}
}

using UnityEngine;
using System.Collections;

public class s_Bars : MonoBehaviour {

	public GameObject End_A, End_B, End_C;
	public s_GameManager gameManager;


	// Use this for initialization
	void Start () {
		gameManager = GameObject.Find ("GameManager").GetComponent<s_GameManager> ();
		End_A.SetActive(false);
		End_B.SetActive(false);	
		End_C.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {	
		ShowBars();
	}


	public void ShowBars(){
		if(gameManager.EndOne == true){
			End_A.SetActive(true);;
		}
		else if(gameManager.EndTwo == true){
			End_B.SetActive(true);		
		}
		else if(gameManager.EndBoth == true){
			End_C.SetActive(true);
		}
	}
}

using UnityEngine;
using System.Collections;

public class s_Bars : MonoBehaviour {

	public GameObject Bars1, Bars2;
	public s_GameManager gameManager;


	// Use this for initialization
	void Start () {
		gameManager = GameObject.Find ("GameManager").GetComponent<s_GameManager> ();
		Bars1.SetActive(false);
		Bars2.SetActive(false);	
	}
	
	// Update is called once per frame
	void Update () {	
		ShowBars();
	}


	public void ShowBars(){
		if(gameManager.EndOne == true){
			Bars2.SetActive(true);
		}
		else if(gameManager.EndTwo == true){
			Bars1.SetActive(true);
		}
	}
}

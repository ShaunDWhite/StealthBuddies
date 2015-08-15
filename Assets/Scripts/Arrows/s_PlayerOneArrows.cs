using UnityEngine;
using System.Collections;

public class s_PlayerOneArrows : MonoBehaviour {

	public s_GameManager gameManager;
	public GameObject ArrowLeft, ArrowRight;


	// Use this for initialization
	void Start () {
		gameManager = GameObject.Find ("GameManager").GetComponent<s_GameManager> ();
	}
	
	// Update is called once per frame
	void Update () {
			
		if(gameManager.P1_Move == true){
			ArrowLeft.SetActive(false);
			ArrowRight.SetActive(false);
		}
		if(gameManager.P1_Move == false){
			ArrowLeft.SetActive(true);
			ArrowRight.SetActive(true);
		}
	}
}

using UnityEngine;
using System.Collections;

public class s_PlayerOneArrows : MonoBehaviour {

	public s_GameManager gameManager;
	public GameObject ArrowLeft, ArrowRight;
	public GameObject ArrowLeft_2, ArrowRight_2;


	// Use this for initialization
	void Start () {
		gameManager = GameObject.Find ("GameManager").GetComponent<s_GameManager> ();
	}
	
	// Update is called once per frame
	void Update () {
			
		//P1 arrows

		if((gameManager.P1_Move == true) && (gameManager.P1_Detected == false)){
			ArrowLeft.SetActive(false);
			ArrowRight.SetActive(false);
		}
		if((gameManager.P1_Move == false) && (gameManager.P1_Detected == true)){
			ArrowLeft.SetActive(true);
			ArrowRight.SetActive(true);
		}

		//P2 Arrows

		if((gameManager.P2_Move == true) && (gameManager.P2_Detected == false)){
			ArrowLeft_2.SetActive(false);
			ArrowRight_2.SetActive(false);
		}
		if((gameManager.P2_Move == false) && (gameManager.P2_Detected == true)){
			ArrowLeft_2.SetActive(true);
			ArrowRight_2.SetActive(true);
		}
	}
}

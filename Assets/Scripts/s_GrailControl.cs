using UnityEngine;
using System.Collections;

public class s_GrailControl : MonoBehaviour {

	public s_GameManager gameManager;
	public GameObject Grail_1, Grail_2;


	// Use this for initialization
	void Start () {
		gameManager = GameObject.Find ("GameManager").GetComponent<s_GameManager> ();
		Grail_1.SetActive(false);
		Grail_2.SetActive(false);

	
	}
	
	// Update is called once per frame
	void Update () {

		if(gameManager.playerOneHolyGrail){
			Grail_1.SetActive(true);
		}
		if(gameManager.playerTwoHolyGrail){
			Grail_2.SetActive(true);
		}


	
	}
}

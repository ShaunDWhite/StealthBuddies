using UnityEngine;
using System.Collections;

public class s_TriggerMixTape : MonoBehaviour {


	
	public s_GameManager gameManager;
	
	
	
	// Use this for initialization
	void Start () {
		gameManager = GameObject.Find ("GameManager").GetComponent<s_GameManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "Player One") {
			print ("PLAYER ONE HAS THE HOLY GRAIL");
			gameManager.playerOneHolyGrail = true;
			Destroy(gameObject);
		} else if (col.tag == "Player Two") {
			print ("PLAYER TWO HAS THE HOLY GRAIL");
			gameManager.playerTwoHolyGrail = true;
			Destroy(gameObject);
		}
	}
	
	
}
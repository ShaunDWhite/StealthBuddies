using UnityEngine;
using System.Collections;

public class s_GetTheTextPopUps : MonoBehaviour {
	public s_GameManager gameManager;

	public GameObject grabText;
	public GameObject saveText;
	public GameObject whoText;

	// Use this for initialization
	void Start () {
		gameManager = GameObject.Find ("GameManager").GetComponent<s_GameManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (gameManager.grab == true) {
			grabText.SetActive (true);
			saveText.SetActive (false);	
			whoText.SetActive (false);	
			gameManager.save = false;
			gameManager.who = false;
		}
		if (gameManager.save == true) {
			saveText.SetActive (true);
			grabText.SetActive (false);	
			whoText.SetActive (false);
			gameManager.grab = false;
			gameManager.who = false;
		}
		if (gameManager.who == true) {
			whoText.SetActive (true);
			saveText.SetActive (false);	
			grabText.SetActive (false);
			gameManager.grab = false;
			gameManager.save = false;
		}	
	}
}

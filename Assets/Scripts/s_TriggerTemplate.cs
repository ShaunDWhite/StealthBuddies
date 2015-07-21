using UnityEngine;
using System.Collections;

public class s_TriggerTemplate : MonoBehaviour {


	public s_GameManager gameManager;

	// Use this for initialization
	void Start () {
		gameManager = GameObject.Find ("GameManager").GetComponent<s_GameManager> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

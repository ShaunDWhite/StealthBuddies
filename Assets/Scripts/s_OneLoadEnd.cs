using UnityEngine;
using System.Collections;

public class s_OneLoadEnd : MonoBehaviour {

	public bool One, Two;
	public s_GameManager gameManager;


	// Use this for initialization
	void Start () {
		gameManager = GameObject.Find ("GameManager").GetComponent<s_GameManager> ();
		One = false;
		Two = false;
	}
	
	// Update is called once per frame
	void Update () {
		LoadEnd ();
	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.name == "PlayerOneTest"){
			One = true;
		}
		if(col.gameObject.name == "PlayerTwoTest"){
			Two = true;
		}
	}
	
	void OnTriggerExit2D(Collider2D col){
		if(col.gameObject.name == "PlayerOneTest"){
			One = false;
		}
		if(col.gameObject.name == "PlayerTwoTest"){
			Two = false;
		}
	}
	
	void LoadEnd(){
		if (One == true) {
						// Load End Scene for player one
				} else if (Two == true) {
					//load end scene for player two. 
				}
	}
}

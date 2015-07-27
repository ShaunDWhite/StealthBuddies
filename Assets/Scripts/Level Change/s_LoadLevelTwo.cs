using UnityEngine;
using System.Collections;

public class s_LoadLevelTwo : MonoBehaviour {

	public bool One = false;
	public bool Two = false;





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


	void Update(){
		LoadNextLevel();		
	}

	void LoadNextLevel(){
		if((One == true) && (Two == true)){
			Application.LoadLevel("Level_2");
		}
	}

}

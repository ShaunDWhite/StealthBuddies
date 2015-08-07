using UnityEngine;
using System.Collections;

public class s_LoadNextLevel : MonoBehaviour {

	public bool One = false;
	public bool Two = false;


	void Start(){
		One = false;
		Two = false;
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


	void Update(){
		LoadNextLevel();	
	}

	void LoadNextLevel(){
		if((One == true) && (Two == true)){
			if(Application.loadedLevelName == "Level_1_Test"){
				Application.LoadLevel("Level_2");
			}
			if(Application.loadedLevelName == "Level_2"){
				Application.LoadLevel("Level_3");
			}
			if(Application.loadedLevelName == "Level_3"){
				Application.LoadLevel("Level_4");
			}
			if(Application.loadedLevelName == "Level_4"){
				Application.LoadLevel("Level_5");
			}
			if(Application.loadedLevelName == "Level_5"){
				Application.LoadLevel("FinalLevel");
			}
		}
	}

}

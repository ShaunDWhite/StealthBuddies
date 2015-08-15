using UnityEngine;
using System.Collections;

public class s_GameManager : MonoBehaviour {
	public static s_GameManager instance = null;
	//We'll need to make these scripts as part of the 
	//public s_PlayerOne playerOne;
	//public s_PlayerTwo playerTwo;
	

	public bool isPlayerOneDetected;
	public bool isPlayerTwoDetected;

	//Final Level Bool to decide who has the grail. 
	public bool playerOneHolyGrail;
	public bool playerTwoHolyGrail;

	public bool grab;
	public bool save;
	public bool who;

	public bool P1_Move;
	public bool P2_Move;


	public bool EndOne = false;
	public bool EndTwo = false;
	public bool	EndBoth = false;

	public bool L5Laser = true;

	//Awake is always called before any Start functions
	void Awake()
	{
		//Check if instance already exists
		if (instance == null) {
						//if not, set instance to this
						instance = this;
				}
		//If instance already exists and it's not this:
		else if (instance != this) {
						//Then destroy this. Makes sure there is only one!
						Destroy (gameObject);    
				}
		//Sets this to not be destroyed when reloading scene
		DontDestroyOnLoad(gameObject);

		
	
	}


	void Start(){
		P1_Move = true;
		P2_Move = true;
	}



	
	// Update is called once per frame
	void Update () {
			if (Application.loadedLevelName == "MainMenu") {
			EndOne = false;
			EndTwo = false;
			EndBoth = false;
			grab = true;
			L5Laser = true;
				}

				if(Application.loadedLevelName == "EndGame"){
					LoadEnd();
				}				
		}

	public void Detected(){
		Application.LoadLevel(Application.loadedLevel);
		//StartCoroutine(RestartLevel() );
	}

	public void LoadEnd(){
		if(EndOne == true){
			Debug.Log("one end");
		}
		if(EndTwo == true){
			Debug.Log("two end");
		}
		if(EndBoth == true){
			Debug.Log("both end");
		}
	}

//	public IEnumerator RestartLevel(){
//		P1_Move = false;
//		yield return new WaitForSeconds(3);
//		//Reset();
//		Application.LoadLevel(Application.loadedLevel);
//		Reset();
//
//	}
//
//	public void Reset(){
//		P1_Move = true;
//		P2_Move = true;
//	}



}

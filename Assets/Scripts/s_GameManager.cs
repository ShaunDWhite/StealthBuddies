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

	public GameObject grabText;
	public GameObject saveText;
	public GameObject whoText;

	public bool EndOne = false;
	public bool EndTwo = false;
	public bool	EndBoth = false;

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
//		if (Application.loadedLevelName == "Level_5") {
//			grabText = GameObject.Find ("Grab");
//			saveText = GameObject.Find ("Save");
//			whoText = GameObject.Find ("Who");
//		}
	}



	
	// Update is called once per frame
	void Update () {

				if (Application.loadedLevelName == "Level_5") {
					grabText = GameObject.Find ("Grab");
					saveText = GameObject.Find ("Save");
					whoText = GameObject.Find ("Who");
				}
				if (grab == true) {
						grabText.SetActive (true);
						saveText.SetActive (false);	
						whoText.SetActive (false);	
						save = false;
						who = false;
				}
				if (save == true) {
						saveText.SetActive (true);
						grabText.SetActive (false);	
						whoText.SetActive (false);
						grab = false;
						who = false;
				}
				if (who == true) {
						whoText.SetActive (true);
						saveText.SetActive (false);	
						grabText.SetActive (false);
						grab = false;
						save = false;
				}
//				if (Application.loadedLevelName == "Level_5") {
//						grabText = GameObject.Find ("Grab");
//						saveText = GameObject.Find ("Save");
//						whoText = GameObject.Find ("Who");
//				}
	
		}


	public void Detected(){
		Application.LoadLevel(Application.loadedLevel);
	}







}

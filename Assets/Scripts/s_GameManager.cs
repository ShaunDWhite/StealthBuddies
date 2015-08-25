using UnityEngine;
using System.Collections;

//Metrics
using CobaltMetrics;
using CobaltMetrics.DataTypes;
using CobaltMetrics.DataTypes.Unity;

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
	public bool reset;
	public bool P1_Detected;
	public bool P2_Detected;


	public bool EndOne = false;
	public bool EndTwo = false;
	public bool	EndBoth = false;

	public bool L5Laser = true;

	// Audio
	public AudioClip LaserClip;
	public AudioClip GuardClip;
	public AudioClip ElectronicClip;
	public AudioClip ButtonClick;
	public bool LaserOnce = true;
	public bool GuardOnce = true;
	public bool ElectronicOnce = true;



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
		LaserOnce = true;
		GuardOnce = true;
		ElectronicOnce = true;
	}



	
	// Update is called once per frame
	void Update () {
			if (Application.loadedLevelName == "MainMenu") {
			EndOne = false;
			EndTwo = false;
			EndBoth = false;
			grab = false;
			save = false;
			who = true;
			L5Laser = true;
			playerOneHolyGrail = false;
			playerTwoHolyGrail = false;
				}

				if(Application.loadedLevelName == "EndGame"){
					LoadEnd();
				}	
	}

	public void Detected(string obj, int player, Vector3 objPos){
//		Application.LoadLevel(Application.loadedLevel);
		if (reset == false) {
			//Metrics Begin
			CMetricNative.Int("playerDetected", player);
			CMetricNative.String("detectedObj", obj);
			CMetricVector.Vector3("detectedObjPos", objPos);
			CMetricNative.Int ("detectedLevel", Application.loadedLevel);
			//Metrics End

			reset = true;
			StartCoroutine (RestartLevel ());
				}
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

	public IEnumerator RestartLevel(){
		if (P1_Detected == true) {
				P1_Move = false;
				P2_Move = false;
		} else if (P2_Detected == true) {
			P1_Move = false;
			P2_Move = false;
		}
		yield return new WaitForSeconds(3);
		Reset();
		Application.LoadLevel(Application.loadedLevel);

	}

	public void Reset(){
		P1_Move = true;
		P2_Move = true;
		reset = false;
		P1_Detected = false;
		P2_Detected = false;
		L5Laser = true;
		who = true;
		save = false;
		ElectronicOnce = true;
		GuardOnce = true;
		LaserOnce = true;
	}


	public void LaserAudio(){
		if(LaserOnce){
			AudioSource.PlayClipAtPoint(LaserClip, transform.position);
			LaserOnce = false;
		}
	}

	public void ElectronicAudio(){
		if(ElectronicOnce){
			AudioSource.PlayClipAtPoint(ElectronicClip, transform.position);
			ElectronicOnce = false;
		}
	}


	public void GuardAudio(){
		if(GuardOnce){
			AudioSource.PlayClipAtPoint(GuardClip, transform.position);
			GuardOnce = false;
		}
	}

	public void ButtonAudio(){
		AudioSource.PlayClipAtPoint(ButtonClick, transform.position);
	}





}

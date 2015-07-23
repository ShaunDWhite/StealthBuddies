using UnityEngine;
using System.Collections;

public class s_GameManager : MonoBehaviour {
	public static s_GameManager instance = null;
	//We'll need to make these scripts as part of the 
	//public s_PlayerOne playerOne;
	//public s_PlayerTwo playerTwo;



	public bool isPlayerOneDetected;
	public bool isPlayerTwoDetected;

	//Just placeholders for where the score can be held. 
	public float playerOneScore;
	public float playerTwoScore;
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

		
		//Call the InitGame function to initialize the first level 
		InitGame ();
	}

	// Use this for initialization
	void InitGame () {
		Application.LoadLevel ("Test_Nic");
		// Commented out because they don't work yet! //playerOne = GameObject.Find ("Player One").GetComponent<s_PlayerOne> ();
		//playerTwo = GameObject.Find ("Player One").GetComponent<s_PlayerTwo> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

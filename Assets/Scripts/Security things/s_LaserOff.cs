using UnityEngine;
using System.Collections;

public class s_LaserOff : MonoBehaviour {

	public s_GameManager gameManager;
	public s_LaserOn LaserOne, LaserTwo, LaserThree, LaserFour, LaserThree_2;
	public float timer = 3;
	public bool L1, L2, L3, L4, LvL3;

	//level 4 stuff
	public bool L4_1, L4_2, L4_4, L4_3;

	// Level 5
	public bool L5_1,  L5_2,  L5_3,  L5_4;


	void Start(){

		gameManager = GameObject.Find ("GameManager").GetComponent<s_GameManager> ();


		// Level 1 - 3

		L1 = false;
		L2 = false;
		L3 = false;
		L4 = false;
		LvL3 = false;

		// Level 4
		L4_1 = false;	
		L4_3 = false;
		L4_2 = false;

		L5_1 = false;	  
		L5_2 = false;	 
		L5_3 = false;	
		L5_4 = false;	

	}



	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.name == "PlayerOneTest"){

			//Level 1 - 3

			if(gameObject.name == "LaserOff_TopLeft"){			
				L3 = true;
			}
			else if(gameObject.name == "LaserOff_TopRight"){
				L4 = true;
			}

			//Level 4

			else if(gameObject.name == "Laser_Off_Button_2"){
				L4_2 = true;
			}
			else if(gameObject.name == "Laser_Off_Button_3"){
				L4_3 = true;
			}
			else if(gameObject.name == "Laser_Off_Button_BackUp"){
				L4_1 = true;
			}

			//Level 5
			else if(gameObject.name == "Laser_Off_Button_P1_1"){
				L5_1 = true;
			}
			else if(gameObject.name == "Laser_Off_Button_P2_2"){
				L5_4 = true;
			}

		}
		else if(col.gameObject.name == "PlayerTwoTest"){

			//Level 1 - 3

			if(gameObject.name == "LaserOff_BottomLeft"){
				L1 = true;
			}
			else if(gameObject.name == "LaserOff_BottomRight"){
				L2 = true;
			}
			else if(gameObject.name == "Laser_Off_Button"){
				LvL3 = true;
			}


			// Level 4

			else if(gameObject.name == "Laser_Off_Button_1"){
				L4_1 = true;
			}
			else if(gameObject.name == "Laser_Off_Button_4"){
				L4_4 = true;
			}

			//Level 5

			else if(gameObject.name == "Laser_Off_Button_P1_2"){
				L5_2 = true;
			}
			else if(gameObject.name == "Laser_Off_Button_P2_1"){
				L5_3 = true;
			}


		}
	}

	void OnTriggerExit2D(Collider2D col){
		if(col.gameObject.name == "PlayerOneTest"){

			// Level 1 - 3

			if(gameObject.name == "LaserOff_TopLeft"){			
				L3 = false;
			}
			else if(gameObject.name == "LaserOff_TopRight"){
				L4 = false;
			}


			//Level 4
			
			else if(gameObject.name == "Laser_Off_Button_2"){
				L4_2 = false;
			}
			else if(gameObject.name == "Laser_Off_Button_3"){
				L4_3 = false;
			}
			else if(gameObject.name == "Laser_Off_Button_BackUp"){
				L4_1 = false;
			}

			//Level 5

			else if(gameObject.name == "Laser_Off_Button_P1_1"){
				L5_1 = false;
			}
			else if(gameObject.name == "Laser_Off_Button_P2_2"){
				L5_4 = false;
			}
		}
		else if(col.gameObject.name == "PlayerTwoTest"){

			// Level 1 - 3

			if(gameObject.name == "LaserOff_BottomLeft"){
				L1 = false;
			}
			else if(gameObject.name == "LaserOff_BottomRight"){
				L2 = false;
			}
			else if(gameObject.name == "Laser_Off_Button") {
				LvL3 = false;
			}


			// Level 4
			
			else if(gameObject.name == "Laser_Off_Button_1"){
				L4_1 = false;
			}
			else if(gameObject.name == "Laser_Off_Button_3_1"){
				L4_4 = false;
			}

			// Level 5

			else if(gameObject.name == "Laser_Off_Button_P1_2"){
				L5_2 = false;
			}
			else if(gameObject.name == "Laser_Off_Button_P2_1"){
				L5_3 = false;
			}
		}
	}


	void Update(){

		//Level 1 - 3


		if(L1){
			if(Input.GetKeyDown(KeyCode.Space)){
				gameManager.ButtonAudio();
				StartCoroutine(LaserOneOff ());
			}
		}
		if(L2){
			if(Input.GetKeyDown(KeyCode.Space)){
				gameManager.ButtonAudio();
				StartCoroutine(LaserTwoOff ());
			}
		}
		if(L3){
			if(Input.GetButtonDown("A")){
				gameManager.ButtonAudio();
				StartCoroutine(LaserThreeOff());
			}
		}
		if(L4){
			if(Input.GetButtonDown("A")){
				gameManager.ButtonAudio();
				StartCoroutine(LaserFourOff());
			}
		}
		if(LvL3){
			if(Input.GetKeyDown(KeyCode.Space)){
				gameManager.ButtonAudio();
				StartCoroutine(LaserOneOff ());
				StartCoroutine(LaserTwoOff ());
			}
		}

		// Level 4	

		if(L4_1){
			if(Input.GetKeyDown(KeyCode.Space)){
				gameManager.ButtonAudio();
				StartCoroutine(LaserOneOff());
			}
			else if(Input.GetButtonDown("A")){
				gameManager.ButtonAudio();
				StartCoroutine(LaserOneOff());
			}
		}
		if(L4_2){
			if(Input.GetButtonDown("A")){
				gameManager.ButtonAudio();
				StartCoroutine(LaserTwoOff());
			}
		}
		if(L4_4){
			if(Input.GetKeyDown(KeyCode.Space)){
				gameManager.ButtonAudio();
				StartCoroutine(LaserFourOff());		
			}
		}


		if(L4_3){
			if(Input.GetButtonDown("A")){
				gameManager.ButtonAudio();
				StartCoroutine(TwinLasers());
				StartCoroutine(LaserThreeOff());
			}
		}

		// Level 5
		if (L5_1) {	
			if((Input.GetButtonDown("A")) && (gameManager.L5Laser == true)){
				gameManager.ButtonAudio();
				StartCoroutine(LaserOneOff());
				// Set the text in the game manager to appear
				gameManager.grab = true;
				gameManager.L5Laser = false;
			}
		}

		if (L5_2) { 
			if((Input.GetKeyDown(KeyCode.Space)) || (Input.GetButtonDown("A"))){
				gameManager.ButtonAudio();
				StartCoroutine(LaserOneOff());
			}
		}

		if (L5_3) { 
			if((Input.GetKeyDown(KeyCode.Space)) &&(gameManager.L5Laser == true)){
				gameManager.ButtonAudio();
				StartCoroutine(LaserTwoOff());
				// Set the text in the game manager to appear
				gameManager.grab = true;
				gameManager.L5Laser = false;
			}
		}

		if (L5_4) { 
			if((Input.GetKeyDown(KeyCode.Space)) || (Input.GetButtonDown("A"))){
				gameManager.ButtonAudio();
				StartCoroutine(LaserTwoOff());
			}
		}


	}




	public IEnumerator LaserOneOff(){
		LaserOne.IsTurnedOn = false;			
		yield return new WaitForSeconds(timer);
		LaserOne.IsTurnedOn = true;
	}
	public IEnumerator LaserTwoOff(){
		LaserTwo.IsTurnedOn = false;			
		yield return new WaitForSeconds(timer);
		LaserTwo.IsTurnedOn = true;
	}
	public IEnumerator LaserThreeOff(){
		LaserThree.IsTurnedOn = false;			
		yield return new WaitForSeconds(timer);
		LaserThree.IsTurnedOn = true;
	}
	public IEnumerator LaserFourOff(){
		LaserFour.IsTurnedOn = false;			
		yield return new WaitForSeconds(timer);
		LaserFour.IsTurnedOn = true;
	}

	public IEnumerator TwinLasers(){
		LaserThree_2.IsTurnedOn = false;			
		yield return new WaitForSeconds(timer);
		LaserThree_2.IsTurnedOn = true;
	}

}

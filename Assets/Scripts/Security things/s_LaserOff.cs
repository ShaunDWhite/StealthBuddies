using UnityEngine;
using System.Collections;

public class s_LaserOff : MonoBehaviour {

	public s_LaserOn LaserOne, LaserTwo, LaserThree, LaserFour, LaserThree_2;
	public float timer = 3;
	public bool L1, L2, L3, L4, LvL3;

	//level 4 stuff
	public bool L4_1, L4_2, L4_4, L4_3;


	void Start(){

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

		}
	}


	void Update(){

		//Level 1 - 3


		if(L1){
			if(Input.GetKeyDown(KeyCode.Space)){
				StartCoroutine(LaserOneOff ());
			}
		}
		if(L2){
			if(Input.GetKeyDown(KeyCode.Space)){
				StartCoroutine(LaserTwoOff ());
			}
		}
		if(L3){
			if(Input.GetButtonDown("A")){
				StartCoroutine(LaserThreeOff());
			}
		}
		if(L4){
			if(Input.GetButtonDown("A")){
				StartCoroutine(LaserFourOff());
			}
		}
		if(LvL3){
			if(Input.GetKeyDown(KeyCode.Space)){
				StartCoroutine(LaserOneOff ());
				StartCoroutine(LaserTwoOff ());
			}
		}

		// Level 4	

		if(L4_1){
			if(Input.GetKeyDown(KeyCode.Space)){
				StartCoroutine(LaserOneOff());
			}
			else if(Input.GetButtonDown("A")){
				StartCoroutine(LaserOneOff());
			}
		}
		if(L4_2){
			if(Input.GetButtonDown("A")){
				StartCoroutine(LaserTwoOff());
			}
		}
		if(L4_4){
			if(Input.GetKeyDown(KeyCode.Space)){
				StartCoroutine(LaserFourOff());		
			}
		}


		if(L4_3){
			if(Input.GetButtonDown("A")){
				StartCoroutine(TwinLasers());
				StartCoroutine(LaserThreeOff());
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

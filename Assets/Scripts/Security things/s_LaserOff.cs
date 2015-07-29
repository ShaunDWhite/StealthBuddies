using UnityEngine;
using System.Collections;

public class s_LaserOff : MonoBehaviour {

	public s_LaserOn LaserOne, LaserTwo, LaserThree, LaserFour;
	public float timer = 5;
	public bool L1, L2, L3, L4, LvL3;


	void Start(){
		L1 = false;
		L2 = false;
		L3 = false;
		L4 = false;
		LvL3 = false;
	
	}



	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.name == "PlayerOneTest"){
			if(gameObject.name == "LaserOff_TopLeft"){			
				L3 = true;
			}
			else if(gameObject.name == "LaserOff_TopRight"){
				L4 = true;
			}
		}
		else if(col.gameObject.name == "PlayerTwoTest"){
			if(gameObject.name == "LaserOff_BottomLeft"){
				L1 = true;
			}
			else if(gameObject.name == "LaserOff_BottomRight"){
				L2 = true;
			}
			else {
				LvL3 = true;
			}
		}
	}

	void OnTriggerExit2D(Collider2D col){
		if(col.gameObject.name == "PlayerOneTest"){
			if(gameObject.name == "LaserOff_TopLeft"){			
				L3 = false;
			}
			else if(gameObject.name == "LaserOff_TopRight"){
				L4 = false;
			}
		}
		else if(col.gameObject.name == "PlayerTwoTest"){
			if(gameObject.name == "LaserOff_BottomLeft"){
				L1 = false;
			}
			else if(gameObject.name == "LaserOff_BottomRight"){
				L2 = false;
			}
			else {
				LvL3 = false;

			}
		}
	}


	void Update(){
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




}

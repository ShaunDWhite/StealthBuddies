using UnityEngine;
using System.Collections;

public class s_LaserOff : MonoBehaviour {

	public s_LaserOn LaserOne, LaserTwo, LaserThree, LaserFour;
	public float timer = 5;

	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.name == "PlayerOneTest"){
			if(gameObject.name == "LaserOff_TopLeft"){
				StartCoroutine(LaserThreeOff());
			}
			else if(gameObject.name == "LaserOff_TopRight"){
				StartCoroutine(LaserFourOff());
			}
		}
		else if(col.gameObject.name == "PlayerTwoTest"){
			if(gameObject.name == "LaserOff_BottomLeft"){
				StartCoroutine(LaserOneOff());
			}
			else if(gameObject.name == "LaserOff_BottomRight"){
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




}

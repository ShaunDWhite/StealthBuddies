using UnityEngine;
using System.Collections;

public class s_ReturnToMainMenu : MonoBehaviour {

	public void Return(){
		Application.LoadLevel("MainMenu");
	}
}

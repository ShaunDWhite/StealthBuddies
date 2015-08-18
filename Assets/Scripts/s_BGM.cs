using UnityEngine;
using System.Collections;

public class s_BGM : MonoBehaviour {

	public static s_BGM instance = null;

		
	void Awake(){

		if (instance == null) {
			instance = this;
		}
		else if (instance != this) {
			Destroy (gameObject);    
		}
		DontDestroyOnLoad(this.gameObject);

	}


	void Start() { 

	}
	
	// Update is called once per frame
	void Update () {

	}
}

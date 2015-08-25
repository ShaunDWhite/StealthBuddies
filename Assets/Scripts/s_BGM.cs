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
		//if(Application.loadedLevel == 0 ||Application.loadedLevel ==  1 ||Application.loadedLevel ==  2 || Application.loadedLevel == 3 ||Application.loadedLevel ==  4 ||Application.loadedLevel ==  5 ||Application.loadedLevel ==  6)
//		if (Application.loadedLevel != 6)
//		{
//			DontDestroyOnLoad(this.gameObject);
//		}
		DontDestroyOnLoad(this.gameObject);
	}


	void Start() { 

	}
	
	// Update is called once per frame
	void Update () {

			if (Application.loadedLevel == 7)
		{
			Destroy(this.gameObject);
		}
		
	}
}

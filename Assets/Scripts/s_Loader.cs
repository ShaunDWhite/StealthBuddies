﻿using UnityEngine;
using System.Collections;

public class s_Loader : MonoBehaviour {
	
	public GameObject gameManager;
	
	// Use this for initialization
	void Awake () {
		
		if (s_GameManager.instance == null)
		{
			Instantiate (gameManager);
	}		
	}	
}

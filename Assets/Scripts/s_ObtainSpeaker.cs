using UnityEngine;
using System.Collections;

public class s_ObtainSpeaker : MonoBehaviour {

	void OnTriggerEnter(Collider col){
		if (col.gameObject.name == "Portable Speaker") {
			Destroy(col.gameObject);
				}
	}
}

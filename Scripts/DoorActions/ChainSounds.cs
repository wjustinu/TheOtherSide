using UnityEngine;
using System.Collections;

public class ChainSounds : MonoBehaviour {
	public static bool triggerOnce = true;

	void OnTriggerEnter(Collider collider){
		if (collider.gameObject.name == "Player" && triggerOnce) {
			Debug.Log("Contact with Player");
			GetComponent<AudioSource>().Play();
			triggerOnce = false;
		
		}
		else{
			Debug.Log("Already Triggered");
		}
		
	}

}
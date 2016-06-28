using UnityEngine;
using System.Collections;

public class ZombieAttack : MonoBehaviour{
	//public GameObject audio;
	public static bool triggerOnce = true;

	void OnTriggerEnter(Collider collider){
		if (collider.gameObject.name == "Player" && triggerOnce) {
			gameObject.GetComponent<Animation>().Play("atack02");
			Debug.Log("Contact with Player");
			gameObject.GetComponent<AudioSource>().Play();
			triggerOnce = false;
		
		}
		else{
			Debug.Log("Already Triggered");
		}
		
	}

}
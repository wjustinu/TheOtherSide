using UnityEngine;
using System.Collections;

public class SpawnZombie : MonoBehaviour{
	public GameObject spawn;

	void OnTriggerEnter(Collider collider){
		if (collider.gameObject.name == "Player" ) {
			spawn.SetActive(true);
			Debug.Log("Contact with Player");
		}
	}
}
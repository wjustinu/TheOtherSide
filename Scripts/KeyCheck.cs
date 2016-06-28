using UnityEngine;
using System.Collections;

public class KeyCheck : MonoBehaviour {

	public static bool respawnCalled;
	public GameObject spawnKey;
	void Start () {
		respawnCalled = false;
	}
	// Update is called once per frame
	void Update () {
		if (respawnCalled) {
			spawnKey.SetActive(true);
			respawnCalled = false;
			
		}
	}
}

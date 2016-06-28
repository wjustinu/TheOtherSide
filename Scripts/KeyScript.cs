using UnityEngine;
using System.Collections;

public class KeyScript : MonoBehaviour {

	public static Vector3 respawnKeyPos;

	public static void keyPosRandomizer () {
		float choice = Random.Range (1.0f, 3.99f);
		if ((int)choice == 1) {
			respawnKeyPos.Set (-39.62f, 0.56f, 54.22f);
		} else if ((int)choice == 2) {
			respawnKeyPos.Set (-47.36f, 0.22f, 58.0f);
		} else if ((int)choice == 3){
			respawnKeyPos.Set (-3.58f, -6.32f, 46.78f);			
		}
	}

	void Start () {
		keyPosRandomizer ();
		transform.position = respawnKeyPos;

	}

	void OnEnable () {
		if (KeyCheck.respawnCalled) {
			transform.position = respawnKeyPos;
			PlayerStats.keyObject = 0;
			KeyCheck.respawnCalled = false;
		}
	}

	void OnMouseDown() {
		gameObject.SetActive(false);
		PlayerStats.keyObject = 1;
	}
		
}

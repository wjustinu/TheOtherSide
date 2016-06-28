using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerStats : MonoBehaviour {
	
	public static int keyObject = 1; //for testing purposes, change to 0 on build. 
	public static Vector3 respawnPlayerPos;
	public static bool respawnCalled;
	//public static int lives;
	//public Text livesText;

	void Start () {
		//livesText.text = "Lives: " + lives.ToString (); 
		respawnCalled = false;
	}

	void Update () {
		//livesText.text = "Lives: " + lives.ToString (); 
	if (respawnCalled) {
			transform.position = respawnPlayerPos;
			respawnCalled = false;
		}
	}


}

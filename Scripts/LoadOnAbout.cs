using UnityEngine;
using System.Collections;

public class LoadOnAbout : MonoBehaviour {

	public GameObject aboutImage;
	public GameObject loadingImage;

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Mouse0)) {
			loadingImage.SetActive (true);
			Destroy(aboutImage.gameObject);
			Application.LoadLevel (2);
            //Reset Timer
            CountdownTimer.seconds = 44;
            CountdownTimer.minutes = 4; //switch to 4 on build
            //Reset Player Position
            PlayerStats.respawnPlayerPos.Set(-75.0f, 0.8f, -94.0f);
            PlayerStats.respawnCalled = true;
            loadingImage.SetActive (false);
		}
	}
}

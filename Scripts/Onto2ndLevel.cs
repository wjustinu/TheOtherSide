using UnityEngine;
using System.Collections;

public class Onto2ndLevel : MonoBehaviour {
	public static bool isCollided = false;
	private float displayTime = 3;
	private float startTime = 0;

	void OnTriggerEnter(Collider collider){
		if (collider.gameObject.name == "Player" && PlayerStats.keyObject > 0) {
			PlayerStats.keyObject--;
			Application.LoadLevel (3);
			//Reset Timer
			CountdownTimer.seconds = 44;
			CountdownTimer.minutes = 4;
			//Reset Player Position
			PlayerStats.respawnPlayerPos.Set(-6.6f,9.5f,0.0f);
			PlayerStats.respawnCalled = true;
		}
		else {
			isCollided = true;
			GetComponent<AudioSource>().Play();
			startTime = Time.time;
		}
	}
	void OnGUI(){
		if(isCollided && PlayerStats.keyObject == 0){
			if((Time.time - startTime) < displayTime){
				GUI.Label(new Rect(Screen.width/2,Screen.height/2,100,100),"It's locked...");
			}
		}
		else
			isCollided = false;
	}
}
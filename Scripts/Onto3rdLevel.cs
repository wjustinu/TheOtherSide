using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Onto3rdLevel : MonoBehaviour {

	public Canvas popUp;
	[SerializeField]
	private InputField input;
	[SerializeField]
	public BoxCollider knobCollider;
	[SerializeField]
	public Text text;

	public static bool soundPlayed = false;
	private string code;

	void randomTextGen () {
		//Randomize Text
		int choice = (int)Random.Range (1.0f, 3.99f);
		if (choice == 1) {
			text.text = "You know what to do...";
		} else if (choice == 2) {
			text.text = "The walls are scratched up...";
		} else if (choice == 3){
			text.text = "They're around you...";			
		}
	}

	// Use this for initialization
	void Awake () {
		popUp.enabled = false;
		popUp = popUp.GetComponent<Canvas> ();
		knobCollider = GetComponent<BoxCollider> ();

		code = "false";
		randomTextGen ();
	}
		
	void OnMouseDown() {
		popUp.enabled = true;
		knobCollider.enabled = false;
        //disables player movement while UI is up
		GameObject.Find("Player").GetComponent<CharacterController>().enabled = false;
	}

	public void GetInput(string enteredCode) {
		if (enteredCode.ToLower() == code) {
			//Go to next level
			Application.LoadLevel (4);
			//Reset Timer
			CountdownTimer.seconds = 44;
			CountdownTimer.minutes = 4; //switch to 4 on build
			//Reset Player Position
			PlayerStats.respawnPlayerPos.Set(56.5f,1.0f,-4.0f);
			PlayerStats.respawnCalled = true;
		}
		else { //When code is wrong!
			if(soundPlayed == false){
				GetComponent<AudioSource>().Play();
			}
			soundPlayed = true;	
			input.text = ""; //clears strings after hitting enter
			popUp.enabled = false;
			knobCollider.enabled = true;
			randomTextGen ();
		}
        //enable player movement after UI is closed
		GameObject.Find("Player").GetComponent<CharacterController>().enabled = true;
	
	}


}

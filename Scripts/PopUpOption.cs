using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PopUpOption : MonoBehaviour {

	public GameObject toDestroy;
	public Canvas popUpMenu;
	public Button optionsText;
	public Button playText;
	public bool isPaused;


	// Use this for initialization
	void Start () {
		popUpMenu.enabled = false;
		popUpMenu = popUpMenu.GetComponent<Canvas> ();	

		optionsText = optionsText.GetComponent<Button> ();
		playText = playText.GetComponent<Button> ();

		//start game unpaused
		isPaused = false;
	}

	public void OptionsPressed() {
		popUpMenu.enabled = true;
		optionsText.enabled = true;
		Time.timeScale = 0.0f; //paused
	}

	public void PlayPressed() {
		popUpMenu.enabled = false;
		optionsText.enabled = true;
		Time.timeScale = 1.0f; //play
	}

	public void RestartLevel() {
		popUpMenu.enabled = false;
		optionsText.enabled = true;
		GameObject.Find("Player").GetComponent<CountdownTimer>().enabled = true;
        GameObject.Find("GameOver").SetActive(false);

		if (Application.loadedLevel == 2) {
			ResetLevel1 ();
		}
		if (Application.loadedLevel == 3) {
			ResetLevel2 ();
		}
		if (Application.loadedLevel == 4) {
			//ResetLevel3 ();
		}
        //Reset Timer
        CountdownTimer.seconds = 44;
        CountdownTimer.minutes = 4; //switch to 4 on build
        Time.timeScale = 1.0f; //play
    }

	public void MenuPressed() {
		Application.LoadLevel (0);
		Destroy(toDestroy.gameObject);
	}

	void ResetLevel1() {
		//Reset Player Position
		PlayerStats.respawnPlayerPos.Set(-75.0f,0.8f,-94.0f);
		PlayerStats.respawnCalled = true;
		//Reset Randomize Key Position
		KeyScript.keyPosRandomizer ();
		KeyCheck.respawnCalled = true;
		//Reset Zombie Animation
		if(ZombieAttack.triggerOnce ==false){
			ZombieAttack.triggerOnce = true;
			GameObject.Find("Animated Zombie").SetActive(false);
		}
	}

    void ResetLevel2()  {
        //Reset Player Position
        PlayerStats.respawnPlayerPos.Set(-6.6f, 9.5f, 0.0f);
        PlayerStats.respawnCalled = true;
        //Sound played reset
        Onto3rdLevel.soundPlayed = false;
    }


}
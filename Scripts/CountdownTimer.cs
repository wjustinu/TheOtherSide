using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CountdownTimer : MonoBehaviour
{
	public static float seconds;
	public static float minutes;
	//[SerializeField]
    public  GameObject GameOverMenu;

	public Text timerText;

	void Start()
	{
		seconds = 4;
		minutes = 44; //switch to 4 on build
		timerText.text = minutes.ToString("f0") + ":" + seconds.ToString("f0");

		GameOverMenu.SetActive(false);
	}

	void Update()
	{
        if (seconds <= 0)
		{
			seconds = 59;
			if(minutes >= 1)
			{
				minutes--;
			}
			else
			{
                minutes = 0;
                seconds = 0;
                    // makes GUI text show the time as X:XX
                    // ToString ("f0") formats it so there is no decimal place
                    timerText.text = minutes.ToString("f0") + ":0" + seconds.ToString("f0");

                    //Stop Time & Restart time, to prevent repetition
                    // Time.timeScale = 0.0f; //paused
                    //seconds = 44;
                    // minutes = 4;
                    //GameOver = false;
                    GameOverMenu.SetActive(true);
                    this.enabled = false; // stops script, renable on restart action
			}
		}
		else
		{
			seconds -= Time.deltaTime;
		}
		// The ff condition make sure the time is shown as X:XX and not X.XX.XXXX
		if(Mathf.Round(seconds) <= 9)
		{
			timerText.text = minutes.ToString("f0") + ":0" + seconds.ToString("f0");
		}
		else
		{
			timerText.text = minutes.ToString("f0") + ":" + seconds.ToString("f0");
		}
			
	}
}

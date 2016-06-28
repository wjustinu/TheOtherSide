using UnityEngine;
using System.Collections;

public class SaveAndLoad : MonoBehaviour {

	public Transform player;
	public GUI saveButton, loadButton;
	public int score = 0;

	void OnGUI()
	{
		if (GUI.Button (new Rect (470, 200, 70, 20), "Save"))
			SaveStuff ();
		if (GUI.Button (new Rect (570, 200, 70, 20), "Load"))
			LoadStuff ();
	}

	void SaveStuff()
	{
		PlayerPrefs.SetInt ("Score", score);
		PlayerPrefs.SetFloat ("playerPosX", player.position.x);
		PlayerPrefs.SetFloat ("playerPosY", player.position.y);
		PlayerPrefs.SetFloat ("playerPosZ", player.position.z);
	}

	void LoadStuff()
	{
		score = PlayerPrefs.GetInt ("Score", 0);
		player.position = new Vector3 (PlayerPrefs.GetFloat ("playerPosX"), PlayerPrefs.GetFloat ("playerPosY"), PlayerPrefs.GetFloat ("playerPosZ"));
	}
}

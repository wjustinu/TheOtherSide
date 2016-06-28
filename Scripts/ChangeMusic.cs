﻿using UnityEngine;
using System.Collections;

public class ChangeMusic : MonoBehaviour {

	public AudioClip level1Music;
	public AudioClip level2Music;
	public AudioClip level3Music;

	private AudioSource source;
	// Use this for initialization
	void Awake () {
		source = GetComponent<AudioSource> ();
	}

	void  OnLevelWasLoaded (int level){
		if (level == 2) {
			source.clip = level1Music;
			source.Play ();
		}
		if (level == 3) {
			source.clip = level2Music;
			source.Play ();
		}
		if (level == 4) {
			source.clip = level3Music;
			source.Play ();
		}
	}
}

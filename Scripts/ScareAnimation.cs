using UnityEngine;
using System.Collections;

public class ScareAnimation : MonoBehaviour{
	public void OnEnable(){
		GetComponent<Animation>().CrossFadeQueued("creep up");
		GetComponent<Animation>().CrossFadeQueued("death01");
		GetComponent<AudioSource>().pitch = 0.78f;
	}

}
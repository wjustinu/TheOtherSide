using UnityEngine;
using System.Collections;

public class LightIntensity : MonoBehaviour {
	public static float lightIntensity;
	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		lightIntensity = CountdownTimer.minutes  + CountdownTimer.seconds/100;
		GetComponent<Light>().intensity = lightIntensity;
	}
}
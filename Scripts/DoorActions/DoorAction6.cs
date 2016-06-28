using UnityEngine;
using System.Collections;

public class DoorAction6 : MonoBehaviour {
	public float distanceMax = 4;
	private GameObject playerPosition;
	private float distance;
	public static bool triggerOnce = true;

	// Use this for initialization
	void Start () {
		playerPosition = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
		distance = Vector3.Distance(playerPosition.transform.position, transform.position);
		
		if((distance < distanceMax) && triggerOnce){
			GetComponent<Animation>().Play();
			GetComponent<AudioSource>().Play();

			GameObject.Find("Door13").GetComponent<Animation>().Play();
			triggerOnce = false;
		}
	}
}

using UnityEngine;
using System.Collections;

public class DoorAction3 : MonoBehaviour {
	public float distanceMax = 2;
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
			GetComponent<AudioSource>().Play();
			triggerOnce = false;
		}
	}
}

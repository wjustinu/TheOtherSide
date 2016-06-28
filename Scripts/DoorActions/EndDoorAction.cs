using UnityEngine;
using System.Collections;

public class EndDoorAction : MonoBehaviour {
	public float distanceMax = 1;
	private GameObject playerPosition;
	private float distance;
	public static bool triggerOnce = true;
	public float targetTime = 1.8f;

	// Use this for initialization
	void Start () {
		playerPosition = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
		distance = Vector3.Distance(playerPosition.transform.position, transform.position);
		
		if((distance < distanceMax) && triggerOnce){
			GetComponent<Animation>().Play();
			triggerOnce = false;
		}
		if(triggerOnce == false){
			targetTime -= Time.deltaTime;
			Debug.Log(targetTime);
			if(targetTime < 0){
				Application.LoadLevel(5);
			}
		}
	}
}

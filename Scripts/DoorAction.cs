// using UnityEngine;
// using System.Collections;

// public class DoorAction : MonoBehaviour {
// 	public float distanceMax = 4;
// 	private GameObject playerPosition;
// 	private float distance;
// 	public static bool triggerOnce = true;
// 	public float targetTime = 2.0f;

// 	// Use this for initialization
// 	void Start () {
// 		playerPosition = GameObject.Find("Player");
// 	}
	
// 	// Update is called once per frame
// 	void Update () {
// 		distance = Vector3.Distance(playerPosition.transform.position, transform.position);
// 		timer = CountdownTimer.seconds;
// 		if((distance < distanceMax) && triggerOnce){
// 			GetComponent<Animation>().Play();
// 			triggerOnce = false;
// 		}
// 		if(triggerOnce == false){
// 			targetTime -= Time.deltaTime;
// 			if(targetTime == 0){
// 				Application.LoadLevel(5)
// 			}
// 		}

// 	}
// }

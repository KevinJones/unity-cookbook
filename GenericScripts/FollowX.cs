using UnityEngine;
using System.Collections;

public class FollowX : MonoBehaviour {

	public Transform target;
	public float easeTime = 0.5f;
	
	// Update is called once per frame
	void Update () {
		
		float lerpRate = Time.deltaTime/easeTime;
		float lerpedX = Mathf.Lerp(transform.position.x, target.position.x, lerpRate);
		
		transform.position = transform.position.WithX( lerpedX); 
	}
}

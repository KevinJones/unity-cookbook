using UnityEngine;
using System.Collections;

// NOTE: This behavior isn't working yet.
public class KinematicWanderBehaviour : MonoBehaviour {
	
	public float maxSpeed = 5.0f;
	public float maxRotation = 300.0f;
	
	private KinematicWander wander;
	
	
	// Use this for initialization
	void Start () {
		StaticTransform charStatic = new StaticTransform(transform);
		wander = new KinematicWander(charStatic, maxSpeed, maxRotation);
	}
	
	// Update is called once per frame
	void Update () {
		// Vector3 beforeAngles = transform.eulerAngles;

		KinematicSteerHelper.ApplySteer(wander, transform);
		
		// Vector3 afterAngles = transform.eulerAngles;
		// Debug.Log(string.Format("Angles before wander: {0} and after: {1}", beforeAngles, afterAngles));
		// KinematicSteerHelper.ApplySteerAndFaceMovementDirection(wander, transform);
	}
}

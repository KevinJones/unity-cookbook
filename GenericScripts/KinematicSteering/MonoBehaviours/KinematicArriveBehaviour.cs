using UnityEngine;
using System.Collections;

public class KinematicArriveBehaviour : MonoBehaviour {

	public Transform target;
	public float maxSpeed = 5.0f;
	public float arriveGoalRadius = 3.0f;
	public float arriveTimeToTarget = 0.25f;

	private KinematicArrive arrive; 

	// Use this for initialization
	void Start () {
		StaticTransform charStatic = new StaticTransform(transform);
		StaticTransform targetStatic = new StaticTransform(target);
		arrive = new KinematicArrive(charStatic, targetStatic, maxSpeed, arriveGoalRadius, arriveTimeToTarget);
	}
	
	// Update is called once per frame
	void Update () {
		KinematicSteerHelper.ApplySteerAndFaceMovementDirection(arrive, transform);		
	}
}

using UnityEngine;
using System.Collections;

/// <summary>
/// Flees away from a target at a constant speed.
/// </summary>
public class KinematicFleeBehaviour : MonoBehaviour {

	public Transform target;
	public float maxSpeed = 5.0f;
	private KinematicFlee flee;

	// Use this for initialization
	void Start () {
		StaticTransform charStatic = new StaticTransform(transform);
		StaticTransform targetStatic = new StaticTransform(target);
		flee = new KinematicFlee(charStatic, targetStatic, maxSpeed);
	}
	
	// Update is called once per frame
	void Update () {
		KinematicSteerHelper.ApplySteerAndFaceMovementDirection(flee, transform);
	}
}

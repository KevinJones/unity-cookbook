using UnityEngine;
using System.Collections;

/// <summary>
/// Seeks towards a target at constant speed.
/// </summary>
public class KinematicSeekBehaviour : MonoBehaviour {

	public Transform target;
	public float maxSpeed = 5.0f;
	private KinematicSeek seek;

	// Use this for initialization
	void Start () {
		// construct seek
		StaticTransform charStatic = new StaticTransform(transform);
		StaticTransform targetStatic = new StaticTransform(target);
		seek = new KinematicSeek(charStatic, targetStatic, maxSpeed);
	}
	
	// Update is called once per frame
	void Update () {
		KinematicSteerHelper.ApplySteerAndFaceMovementDirection(seek, transform);
	}
}

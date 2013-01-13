using UnityEngine;
using System.Collections;

public class KinematicArrive : IKinematicSteering {

	public StaticTransform character { get; set; }
	public StaticTransform target { get; set; }

	public float maxSpeed { get; set; }
	public float goalRadius { get; set; }
	public float timeToTarget { get; set; }

	public KinematicArrive(StaticTransform _character, 
							StaticTransform _target,
							float _maxSpeed,
							float _goalRadius,
							float _timeToTarget)
	{
		character = _character;
		target = _target;
		maxSpeed = _maxSpeed;
		goalRadius = _goalRadius;
		timeToTarget = _timeToTarget;
	}

	public KinematicSteeringOutput GetSteering()
	{
		KinematicSteeringOutput steering = new KinematicSteeringOutput();

		steering.velocity = target.position - character.position;
		bool shouldStop = steering.velocity.magnitude < goalRadius;
		if (shouldStop)
		{
			steering.velocity = Vector3.zero;
			steering.rotation = Angle.WithDeg(0);
			return steering;
		}

		// get to the target in timeToTarget seconds
		steering.velocity /= timeToTarget;

		// clip to max speed
		if (steering.velocity.magnitude > maxSpeed)
		{
			steering.velocity.Normalize();
			steering.velocity *= maxSpeed;
		}

		steering.rotation = Angle.WithDeg(0);
		return steering;
	}
}

using UnityEngine;
using System.Collections;

public class KinematicSeek : IKinematicSteering{

	public StaticTransform character { get; set; }
	public StaticTransform target { get; set; }

	public float maxSpeed { get; set; } // meters per second

	public KinematicSeek(StaticTransform _character, StaticTransform _target, float _maxSpeed)
	{
		character = _character;
		target = _target;
		maxSpeed = _maxSpeed;
	}

	public KinematicSteeringOutput GetSteering()
	{
		KinematicSteeringOutput steering = new KinematicSteeringOutput();

		// determine new velocity
		steering.velocity = target.position - character.position;
		steering.velocity.Normalize();
		steering.velocity *= maxSpeed;

		steering.rotation = Angle.WithDeg(0);

		return steering;
	}
}

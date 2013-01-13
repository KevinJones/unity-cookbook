using UnityEngine;
using System.Collections;

public class KinematicWander : IKinematicSteering {
	
	public StaticTransform character { get; set; }
	
	public float maxSpeed { get; set; }
	public float maxRotationDegrees { get; set; }
	
	public KinematicWander(StaticTransform character, float maxSpeed, float maxRotation)
	{
		this.character = character;
		this.maxSpeed = maxSpeed;
		this.maxRotationDegrees = maxRotation;
	}
	
	public KinematicSteeringOutput GetSteering()
	{
		KinematicSteeringOutput steering = new KinematicSteeringOutput();
		
		steering.velocity = maxSpeed * character.orientation.vector;
		
		// change orientation randomly
		steering.rotation = Angle.WithDeg(RandomExtensions.GetBinomialValue() * maxRotationDegrees);
		
		return steering;
	}
}

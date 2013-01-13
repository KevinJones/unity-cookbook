using UnityEngine;
using System.Collections;

public class KinematicSteerHelper {

	public static void ApplySteerAndFaceMovementDirection(IKinematicSteering steering, Transform trans)
	{
		KinematicSteeringOutput ksOut = steering.GetSteering();

		ApplySteer(ksOut, trans);
		FaceMovementDirection(ksOut, trans);
	}
	
	public static void ApplySteer(IKinematicSteering steering, Transform trans)
	{
		KinematicSteeringOutput ksOut = steering.GetSteering();
		
		ApplySteer(ksOut, trans);
	}
	
	protected static void ApplySteer(KinematicSteeringOutput ksOut, Transform trans)
	{
		trans.Translate(ksOut.velocity * Time.deltaTime, Space.World);

		trans.Rotate( ksOut.rotation.eulerAngles * Time.deltaTime, Space.World);
	}
	
	protected static void FaceMovementDirection(KinematicSteeringOutput ksOut, Transform trans)
	{
		Angle currentOrientation = Angle.WithEulerAngles(trans.eulerAngles);
		Angle newOrientation = SteeringStructFunctions.GetNewOrientation(currentOrientation, ksOut.velocity);
		trans.eulerAngles = newOrientation.eulerAngles;
	}
}

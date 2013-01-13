using UnityEngine;
using System.Collections;

public class Angle
{
	private float deg;
	 
	public Angle()
	{
		deg = 0;	
	}
	
	public static Angle WithDeg(float d)
	{
		Angle a = new Angle();
		a.degrees = d;
		return a;
	}
	
	public static Angle WithRad(float r)
	{
		Angle a = new Angle();
		a.radians = r;
		return a;
	}

	public static Angle WithEulerAngles(Vector3 eulerAngles)
	{
		Angle a = new Angle();
		a.eulerAngles = eulerAngles;
		return a;
	}
	
	public float degrees
	{
		get { return deg; }
		set { deg = value; }
	}

	public float radians
	{
		get { return deg * Mathf.Deg2Rad; }
		set { deg = value * Mathf.Rad2Deg; }
	}

	public Vector3 vector
	{
		get { return new Vector3(-Mathf.Sin(deg), 0, Mathf.Cos(deg)); }
	}

	public Vector3 eulerAngles
	{
		get { return new Vector3(0, deg, 0); }
		set { deg = value.y; }
	}

	public override string ToString()
	{
		return deg.ToString();
	}

}

public struct KinematicSteeringOutput
{
	public Vector3 velocity;	
	public Angle rotation;		// rotation in CCW degrees about the y-axis, used to adjust orientation.

	public override string ToString()
	{
		return string.Format("vel: {0}, rot: {1}", velocity, rotation);
	}
}

public struct SteeringOutput
{
	public Vector3 linear;	// linear acceleration
	public Angle angular;	// angular acceleration

	public override string ToString()
	{
		return string.Format("linear: {0}, angular: {1}", linear, angular);
	}
}

public class StaticTransform
{
	public Vector3 position
	{
		get { return transform.position; }
		set { transform.position = value; }
	}

	public Angle orientation
	{
		get { return Angle.WithEulerAngles(transform.eulerAngles); }
		set { transform.eulerAngles = value.eulerAngles; }
	}

	public Vector3 orientationEulerAngles
	{
		get { return transform.eulerAngles; }
		set { transform.eulerAngles = value; }
	}

	private Transform transform;

	public StaticTransform(Transform trans)
	{
		transform = trans;
	}

	public override string ToString()
	{
		return string.Format("pos: {0}, ori: {1}", position, orientation);
	}
}

public class KinematicTransform
{
	public Vector3 position
	{
		get { return transform.position; }
		set { transform.position = value; }
	}

	public Angle orientation
	{
		get { return Angle.WithEulerAngles(transform.eulerAngles); }
		set { transform.eulerAngles = value.eulerAngles; }
	}

	public Vector3 orientationEulerAngles
	{
		get { return transform.eulerAngles; }
		set { transform.eulerAngles = value; }
	}

	public Vector3 velocity { get; set; }
	public Angle rotation { get; set; }

	private Transform transform;

	public KinematicTransform(Transform trans)
	{
		transform = trans;
		velocity = Vector3.zero;
		rotation = Angle.WithDeg(0);
	}

	public KinematicTransform(Transform trans, Vector3 vel, float rotDegrees)
	{
		transform = trans;
		velocity = vel;
		rotation = Angle.WithDeg(rotDegrees);
	}
}

public class SteeringStructFunctions
{
	public static float GetNewOrientation(float currentOrientation, Vector3 velocity)
	{
		if (velocity.magnitude > 0)
		{
			// Get the angle in degrees between [1,0,0] and velocity.
			// Multiply by -1 to convert from counterclockwise basis to clockwise.
			return Mathf.Atan2(-velocity.x, velocity.z) * Mathf.Rad2Deg * -1;
		}
		else
		{
			return currentOrientation;
		}
	}
	
	public static Angle GetNewOrientation(Angle currentOrientation, Vector3 velocity)
	{
		if (velocity.magnitude > 0)
		{
			// Get the angle in degrees between [1,0,0] and velocity.
			// Multiply by -1 to convert from counterclockwise basis to clockwise.
			float newAngleRad = Mathf.Atan2(-velocity.x, velocity.z) * -1;
			return Angle.WithRad(newAngleRad);
		}
		else
		{
			return currentOrientation;
		}
	}
}
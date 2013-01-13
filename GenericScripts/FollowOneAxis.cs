using UnityEngine;
using System.Collections;

/// <summary>
/// Matches the X, Y, or Z position of another game object.
/// </summary>
/// Requires VectorExtensions.cs
public class FollowOneAxis : MonoBehaviour {

	public enum Axis
	{
		X,
		Y,
		Z
	}

	public Transform target;
	public float easeTime = 0.5f;
	public Axis followAxis;
	
	// Update is called once per frame
	void Update () {

		float lerpRate = Time.deltaTime/easeTime;

		switch(followAxis)
		{
			case Axis.X:
				FollowX(lerpRate);
				break;
			case Axis.Y:
				FollowY(lerpRate);
				break;
			case Axis.Z:
				FollowZ(lerpRate);
				break;
			default:
				break;
		}
		
	}


	private void FollowX(float lerpRate)
	{
		float lerpedX = Mathf.Lerp(transform.position.x, target.position.x, lerpRate);
		transform.position = transform.position.WithX(lerpedX);
	}

	private void FollowY(float lerpRate)
	{
		float lerpedY = Mathf.Lerp(transform.position.y, target.position.y, lerpRate);
		transform.position = transform.position.WithY(lerpedY);
	}

	private void FollowZ(float lerpRate)
	{
		float lerpedZ = Mathf.Lerp(transform.position.z, target.position.z, lerpRate);
		transform.position = transform.position.WithZ(lerpedZ);
	}
}

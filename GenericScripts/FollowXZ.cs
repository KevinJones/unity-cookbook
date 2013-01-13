using UnityEngine;
using System.Collections;

/// <summary>
/// Smoothly moves a GameObject to match the X and Z coordinates of its target. Useful for an overhead camera in a top-down 2D game.
/// </summary>
public class FollowXZ : MonoBehaviour {

	public Transform target;
	public float dampTime = 0.5f;

	private float xVel;
	private float zVel;
	
	// Update is called once per frame
	void Update () {
	
		if(target)
		{
			transform.position = new Vector3(GetNewXPos(), transform.position.y, GetNewZPos());

			GetNewXPos();
			GetNewZPos();
		}
	}

	float GetNewXPos () 
	{
		float xCurrent = transform.position.x;
		float xTarget = target.position.x;

		return Mathf.SmoothDamp(xCurrent, xTarget, ref xVel, dampTime);
	}

	float GetNewZPos ()
	{
		float zCurrent = transform.position.z;
		float zTarget = target.position.z;

		return Mathf.SmoothDamp(zCurrent, zTarget, ref zVel, dampTime);
	}
}

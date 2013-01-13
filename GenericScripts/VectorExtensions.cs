using UnityEngine;
using System.Collections;

public static class VectorExtensions {
		
	public static Vector3 WithX(this Vector3 v, float _x)
	{
		v.Set(_x, v.y, v.z);
		return v;	
	}
	
	public static Vector3 WithY(this Vector3 v, float _y)
	{
        v.Set(v.x, _y, v.z);
		return v;
	}
	
	public static Vector3 WithZ(this Vector3 v, float _z)
	{
        v.Set(v.x, v.y, _z);
		return v;
	}
	
	public static Vector3 WithMagnitude(this Vector3 v, float _newMagnitude)
	{
		return v.normalized * _newMagnitude;	
	}
}

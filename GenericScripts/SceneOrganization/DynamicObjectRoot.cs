using UnityEngine;
using System.Collections;

/// <summary>
/// A singleton allowing the attached GameObject to serve an empty root object for dynamically allocated GameObjects.
/// </summary>
/// Access this GameObject with DynamicObjectRoot.Instance.
public class DynamicObjectRoot : MonoBehaviour {
	
	private static Transform root;
	
	public static Transform Instance
	{
		get { return root; }
	}
	
	void Start()
	{
		if (!root)
		{
			root = transform;	
		}
		else
		{
			Debug.LogError("More than one Dynamic Object Root in the current scene.");	
		}
	}
	
	void OnDestroy()
	{
		root = null;	
	}
}

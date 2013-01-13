using UnityEngine;
using System.Collections;

/// <summary>
/// Destroy this GameObject after some length of time.
/// </summary>
public class DestroyAfterTime : MonoBehaviour {
	
	public float lifetime;
	
	// Update is called once per frame
	void Update () {		
		if (lifetime <= 0)
		{
			Destroy(gameObject);	
		}
		
		lifetime -= Time.deltaTime;
	}
}

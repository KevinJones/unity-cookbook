using UnityEngine;
using System.Collections;

/// <summary>
/// Rapidly cycles through an array of materials. Good for bullet objects inspired by Contra 3.
/// </summary>
public class CycleThroughMaterials: MonoBehaviour {
	
	public Material[] materials;
	public float delay = (1/15.0f);
		
	private int ii = 0;
	private float timeTillSwap = 0;
	
	// Update is called once per frame
	void Update () {
		if (timeTillSwap <= 0)
		{
			renderer.material = materials[ii];
			ii = (ii + 1) % materials.Length;
			
			timeTillSwap = delay;
		}
		
		timeTillSwap -= Time.deltaTime;
	}
}

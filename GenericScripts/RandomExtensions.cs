using UnityEngine;
using System.Collections;

/// <summary>
/// Helpful random number features not implemented by Unity.
/// </summary>
public static class RandomExtensions {
	
	/// <summary>
	/// Returns a float between -1 and 1 in a binomial distribution centered at 0.
	/// </summary>
	public static float GetBinomialValue()
	{
		float toReturn = Random.value - Random.value;
		
		return toReturn;
	}
	
	/// <summary>
	/// Returns a float between min (inclusive) and max (inclusive) in a binomial distribution centered at (min+max)/2.
	/// </summary>
	public static float GetBinomialRange(float min, float max)
	{
		return Random.Range(min, max) - Random.Range (min, max);
	}
}

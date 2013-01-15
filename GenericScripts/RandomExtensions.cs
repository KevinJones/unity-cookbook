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
		return (Random.Range(min, max) + Random.Range (min, max))/2.0f;
	}
	
	/// <summary>
	/// Returns the result of rolling n m-sided dice.
	/// </summary>
	/// If either diceCount or diceSides is less than one, returns 0.
	public static int RollDice(int diceCount, int diceSides)
	{
		// return zero for exceptional cases.
		if (diceCount < 1 || diceSides < 1)
		{
			return 0;
		}
		
		sum = 0;
		
		int ii = 0;
		while (ii < diceCount)
		{
			sum += Random.Range(1, diceSides);
		}
		
		return sum;
	}
	
}

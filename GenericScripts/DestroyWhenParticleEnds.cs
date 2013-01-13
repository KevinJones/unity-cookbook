using UnityEngine;
using System.Collections;

[RequireComponent(typeof(ParticleSystem))]
public class DestroyWhenParticleEnds : MonoBehaviour {
	
	private float timeToLive;
	
	// Use this for initialization
	void Start () {
		timeToLive = GetComponent<ParticleSystem>().duration;
	}
	
	// Update is called once per frame
	void Update () {
		if (timeToLive <= 0)
		{
			Destroy(gameObject);	
		}
		
		timeToLive -= Time.deltaTime;
	}
}

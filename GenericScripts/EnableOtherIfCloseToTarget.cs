using UnityEngine;
using System.Collections;

public class EnableOtherIfCloseToTarget : MonoBehaviour {

	public MonoBehaviour toEnable;
	public Transform target;
	public float activationDistance = 10.0f;


	// cached values used in Update
	private Vector3 myPos;
	private Vector3 targetPos;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		myPos = transform.position;
		targetPos = target.position;
		if (Vector3.Distance(myPos, targetPos) < activationDistance)
		{
			toEnable.enabled = true;
			this.enabled = false;
		}
	}
}

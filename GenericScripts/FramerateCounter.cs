using UnityEngine;
using System.Collections;

/// <summary>
/// A more accurate frame rate counter that measures the time between one Update() and the next.
/// </summary>
public class FramerateCounter : MonoBehaviour {
	
	private float framerate = 0.0f;
	public Rect counterPosition = new Rect(0, 0, 100, 100);
	private GUIStyle style;
	
	public float highFPS = 60.0f; // ideal
	public float midFPS = 30.0f;  // acceptable if it isn't constant
	public float lowFPS = 10.0f;  // avoid!
	
	// Use this for initialization
	void Start () {
		style = new GUIStyle();
	}
	
	// Update is called once per frame
	void Update () {
		framerate = 1.0f/Time.deltaTime;
		
		if(framerate < lowFPS)
		{
			Debug.LogWarning("FPS is " + framerate);	
		}
	}
	
	void OnGUI () {
		if(framerate > highFPS)
		{
			style.normal.textColor = Color.white;	
		} 
		else if (framerate > midFPS) 
		{
			style.normal.textColor = Color.yellow;
		}
		else
		{
			style.normal.textColor = Color.red;	
		}
		
		
		GUI.Label(counterPosition, framerate.ToString());
	}
}

using UnityEngine;
using System.Collections;

public class ScreenshotButton : MonoBehaviour {
	
	public KeyCode screenshotKey = KeyCode.F10;
	public string filenamePrefix = "game_screen_";
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void LateUpdate () {
		if(Input.GetKeyDown(screenshotKey)){			
			string filename = string.Format("{0}{1}.png",
				filenamePrefix,
				System.DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss"));
			
			Application.CaptureScreenshot(filename);
			Debug.Log("Screenshot captured: " + filename);
		}
	}
}

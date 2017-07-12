using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Time : MonoBehaviour {
	public GameManager gameManager;
	public GUIStyle guiStyle;

	// Use this for initialization
	void OnGUI () {
		Rect position1 = new Rect (10, 10, 200, 40);
		Rect position2 = new Rect (200, 10, 200, 40);

		GUI.Label (position1, "Time: " , guiStyle);
		GUI.Label (position2, gameManager.time.ToString () + " (←減らしていく予定)", guiStyle);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

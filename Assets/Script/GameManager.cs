using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	public static GameManager instance;
	public Inventory inventory;
	public float time = 60;

	// Use this for initialization
	void Start () {
		if (instance == null) {
			instance = this;
		}
		DontDestroyOnLoad (this);
	}
	void Update ()
	{

	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDoor : MonoBehaviour {

	Animator anim;
	AudioClip dooropen;
	AudioSource audiosource;
	public bool conditionNeedItem = false;
		// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		dooropen = Resources.Load<AudioClip> ("Audio/Door Open 1");
		audiosource = GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other){
		if (other.name == "Player") {
			if (conditionNeedItem == false) {
				anim.SetBool ("IsOpen", true);
				audiosource.PlayOneShot (dooropen);
			} else {
				if (GameManager.instance.inventory.HasItem ()) {
					anim.SetBool ("IsOpen", true);
					audiosource.PlayOneShot (dooropen);
				}
			}
		}
	}
	void OnTriggerExit(Collider other){
		if (other.name == "Player") {
			anim.SetBool ("IsOpen", false);
		}
	}

}
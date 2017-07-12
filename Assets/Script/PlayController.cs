using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayController : MonoBehaviour {
	Animator anim;
	GameObject sword;
	SphereCollider swordCollider;
	AudioClip Attackvoice;
	AudioSource audioSource;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		sword = GameObject.Find ("cutter01");
		swordCollider = sword.GetComponent<SphereCollider> ();
		IsAttackingToFalse ();
		Attackvoice = Resources.Load<AudioClip> ("Audio/Human_Good_09");
		audioSource = gameObject.GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			Invoke ("IsAttackingToTrue", 0.5f);
			anim.SetTrigger ("Attack");
			Invoke ("IsAttackingToFalse", 0.8f);
		}
	}
	void IsAttackingToFalse(){
		swordCollider.enabled = false;
	}
	void IsAttackingToTrue(){
		swordCollider.enabled = true;
		audioSource.PlayOneShot (Attackvoice);
	}
}

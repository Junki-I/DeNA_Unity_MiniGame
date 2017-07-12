using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour {
	Animation anim;
	BoxCollider boxCollider;
	public int hp = 100;
	public Image hpGauge;
	int fullHp;
	int attackpower;
	GameObject hpObj;
	SphereCollider swordCollider;
	AudioClip getDamagesound;
	AudioClip Diesound;
	AudioSource audioSource;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animation> ();
		boxCollider = GetComponent<BoxCollider> ();
		hpObj = transform.Find("HP").gameObject;
		fullHp = hp;
		getDamagesound = Resources.Load<AudioClip> ("Audio/Dinosaur_16");
		Diesound = Resources.Load<AudioClip> ("Audio/Dinosaur_21");
		audioSource = gameObject.GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other){
		if (other.name == "cutter01") {
			attackpower = other.GetComponent<Weapon> ().power;
			hp -= attackpower;
			other.GetComponent<SphereCollider> ().enabled = false;
			hpGauge.fillAmount = (float)hp / fullHp;
			if (hp <= 0) {
				anim.Play ("Allosaurus_Die");
				Destroy (boxCollider);
				Destroy (hpObj);
				audioSource.PlayOneShot (Diesound);
			} else if (hp > 0) {
				anim.Play ("Allosaurus_Hit01");
				audioSource.PlayOneShot (getDamagesound);
			}
			} 
	}
}
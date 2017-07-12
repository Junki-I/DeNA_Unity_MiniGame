using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour {

	public Item.Itemtype itemType;
	AudioClip getItemsound;
	AudioSource audioSource;

	// Use this for initialization
	void Start () {
		getItemsound = Resources.Load<AudioClip> ("Audio/DM-CGS-15");
		audioSource = transform.parent.GetComponent<AudioSource> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other){
		if(other.name == "Player"){
			audioSource.PlayOneShot (getItemsound);
			GameManager.instance.inventory.AddItem (itemType);
			Destroy (gameObject);
			GameObject effectObj = gameObject.transform.parent.Find("ItemEffect(Clone)").gameObject;
			Destroy(effectObj);
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {
	List<int> itemList = new List<int> ();

	public void AddItem(Item.Itemtype type){
		itemList.Add ((int)type);
	}
	public bool HasItem(){
		if(itemList.Count >=1){
			return true;
		}else{
			return false;
		}
	}
}

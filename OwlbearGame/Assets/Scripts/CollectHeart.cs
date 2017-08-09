using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectHeart : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D target) {
		PersistentManager.dataStore.gemscollected += 1;
		if (target.gameObject.tag == "Player") {
			Destroy(gameObject);
		}
	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.SceneManagement;

public class PersistentManager : MonoBehaviour {

	public static PersistentManager dataStore;

	//Instance Variables
	public int currentLevelID;

	//Persisted Variables
	public int gemscollected; //Hearts
	public int highestLevelCompleted;

	void Awake() {
		if(dataStore == null) {
			DontDestroyOnLoad (gameObject);
			dataStore = this;
		} else if (dataStore != this) {
			Destroy (gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

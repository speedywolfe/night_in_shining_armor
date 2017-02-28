using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfidenceManager : MonoBehaviour {

	public int playerMaxConfidence;
	public int playerCurrentConfidence;

	// Use this for initialization
	void Start () {
		playerCurrentConfidence = playerMaxConfidence;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ChangeConfidence(int amount) {
		if ((playerCurrentConfidence + amount) > playerMaxConfidence) {
			playerCurrentConfidence = playerMaxConfidence;
		} 
		else if((playerCurrentConfidence + amount) < 0) {
			playerCurrentConfidence = 0;
		}
		else {
			playerCurrentConfidence += amount;
		}
	}
}

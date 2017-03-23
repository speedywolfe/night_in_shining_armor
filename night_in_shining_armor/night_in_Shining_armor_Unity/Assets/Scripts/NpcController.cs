using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcController : MonoBehaviour {

	private GameObject door;
	private bool talkedToGuy;

	void Start() {
		door = GameObject.Find ("outer_door");
	}

	void Update() {
		if(talkedToGuy) {
			door.SetActive(false);
		}
	}

	void OnTriggerStay2D(Collider2D other) {
		if(other.gameObject.name == "Player") {
			if(Input.GetKeyUp(KeyCode.Space)) {
				talkedToGuy = true;
			}
		}
	}
}

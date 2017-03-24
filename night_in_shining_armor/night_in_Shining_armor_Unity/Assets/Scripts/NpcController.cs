using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcController : MonoBehaviour {

	private PlayerController thePlayer;
	private doorController dControl;

	void Start() {
		thePlayer = FindObjectOfType<PlayerController> ();
		dControl = thePlayer.GetComponent<doorController> ();
	}
		
	void OnTriggerStay2D(Collider2D other) {
		if(other.gameObject.name == "Player") {
			if(Input.GetKeyUp(KeyCode.Space)) {
				dControl.academyDoor = true;
			}
		}
	}
}

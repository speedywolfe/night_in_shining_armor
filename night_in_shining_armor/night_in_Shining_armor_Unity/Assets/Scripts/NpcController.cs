using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcController : MonoBehaviour {

	private PlayerController thePlayer;
	private doorController dControl;

	public string whichdoor;

	void Start() {
		thePlayer = FindObjectOfType<PlayerController> ();
		dControl = thePlayer.GetComponent<doorController> ();
	}
		
	void OnTriggerStay2D(Collider2D other) {
		if(other.gameObject.name == "Player") {
			if(Input.GetKeyUp(KeyCode.Space)) {
				if (whichdoor == "academy") {
					dControl.academyDoor = true;
				}
				if (whichdoor == "village") {
					dControl.villageDoor = true;
					thePlayer.gameObject.GetComponent<PlayerHealth> ().SetMaxHealth ();
					thePlayer.gameObject.GetComponent<WeaponController> ().setGreatSword ();
				}
			}
		}
	}
}

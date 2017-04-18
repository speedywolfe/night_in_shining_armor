using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class doorController : MonoBehaviour {

	public bool academyDoor = false;
	private bool academyCheck = false;

	public bool villageDoor = false;
	private bool villageCheck = false;

	public bool clearingDoor = false;
	private bool clearingCheck = false;

	private GameObject door;
	private string sceneName;

	void Update() {
		Scene currentScene = SceneManager.GetActiveScene ();
		sceneName = currentScene.name;
		if(sceneName == "academy") {
			if (!academyCheck) {
				if (academyDoor) {
					door = GameObject.Find ("outer_door");
					door.SetActive (false);
					academyCheck = true;
				}
			}
		}
		else if (sceneName == "village_after") {
			if (!villageCheck) {
				if (villageDoor) {
					door = GameObject.Find ("BottomGate");
					door.SetActive (false);
					villageCheck = true;
				}
			}
		}
		else if (sceneName == "clearing") {
			if (!clearingCheck) {
				if (clearingDoor) {
					door = GameObject.Find ("upper_gate");
					door.SetActive (false);
					door = GameObject.Find ("troll2");
					door.SetActive (false);
					clearingCheck = true;
				}
			}
		}
		else {
			academyCheck = false;
			villageCheck = false;
		}
	}
}

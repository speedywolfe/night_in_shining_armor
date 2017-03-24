using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class doorController : MonoBehaviour {

	public bool academyDoor = false;
	public bool academyCheck = false;
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
		else {
			academyCheck = false;
		}
	}
}

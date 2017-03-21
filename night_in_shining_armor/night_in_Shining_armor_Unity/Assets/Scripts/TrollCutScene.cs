using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrollCutScene : MonoBehaviour {

	private PlayerController thePlayer;
	private Fading fading;

	private float timer = 0.0f;
	public float secsToWait = 3;

	bool startCutScene;

	// Use this for initialization
	void Start () {
		thePlayer = FindObjectOfType<PlayerController> ();
		fading = GetComponent<Fading> ();
	}
	
	// Update is called once per frame
	void Update () {
		thePlayer.canMove = false;
	}

	void OnCollisionEnter2D(Collision2D other) {
		if(other.gameObject.name == "Player") {
			startCutScene = true;
		}
	}

	public void trollTouched() {
		fading.startFadeOut ();
	}
}

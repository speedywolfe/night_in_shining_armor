using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrollCutScene : MonoBehaviour {

	private PlayerController thePlayer;
	private Fading fading;
	private DialogueHolder dHold;
	public string[] cutSceneDialogue;

	private float timer = 3.0f;

	public bool startCutScene;
	private bool timerDone = false;

	// Use this for initialization
	void Start () {
		thePlayer = FindObjectOfType<PlayerController> ();
		fading = GetComponent<Fading> ();
		dHold = GetComponent<DialogueHolder> ();
	}
	
	// Update is called once per frame
	void Update () {
		thePlayer.canMove = false;
		if(startCutScene) {
			timer -= Time.deltaTime;
			if(timer < 0) {
				fading.startFadeIn();
			}
		}
	}
		
	public void trollTouched() {				
		fading.startFadeOut ();
		dHold.isCutScene = true;
		if(timerDone) {
			fading.startFadeOut(); 
		}
	}
}

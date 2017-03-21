using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrollCutScene : MonoBehaviour {

	private PlayerController thePlayer;
	private Fading fading;
	private DialogueHolder dHold;
	public string[] cutSceneDialogue;

	private float timer = 0.0f;

	public bool startCutScene;

	// Use this for initialization
	void Start () {
		thePlayer = FindObjectOfType<PlayerController> ();
		fading = GetComponent<Fading> ();
		dHold = GetComponent<DialogueHolder> ();
	}
	
	// Update is called once per frame
	void Update () {
		thePlayer.canMove = false;
	}
		
	public void trollTouched() {				
		fading.startFadeOut ();
		dHold.isCutScene = true;
	}
}

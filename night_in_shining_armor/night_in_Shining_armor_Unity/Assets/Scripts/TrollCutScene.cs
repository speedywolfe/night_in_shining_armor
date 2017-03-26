using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrollCutScene : MonoBehaviour {

	private PlayerController thePlayer;
	private Fading fading;
	private DialogueManager dMan;
	private DialogueHolder dHold;
	public string[] cutSceneDialogue;

	private float timer = 1.0f;

	public bool startCutScene;
	public bool dialogueFinished;
	private bool timerDone = false;

	// Use this for initialization
	void Start () {
		thePlayer = FindObjectOfType<PlayerController> ();
		fading = GetComponent<Fading> ();
		dMan = FindObjectOfType<DialogueManager> ();
		dHold = GetComponent<DialogueHolder> ();
	}
	
	// Update is called once per frame
	void Update () {
		thePlayer.gameObject.GetComponent<ConfidenceManager>().ChangeConfidence(-1);
		thePlayer.canMove = false;
		if(startCutScene) {
			if(dMan.dialogEnded) {
				thePlayer.gameObject.GetComponent<PlayerHealth> ().BarelyAlive ();
				thePlayer.gameObject.GetComponent<WeaponController> ().setBrokenSword ();
				Application.LoadLevel ("Troll_Arena_after");
				thePlayer.startPoint = "PlayerStart";
				fading.startFadeIn();
			}
		}
	}
		
	public void trollTouched() {				
		fading.startFadeOut ();
		dHold.isCutScene = true;
	}
}

using UnityEngine;
using System.Collections;

public class DialogueHolder : MonoBehaviour {
	
	private DialogueManager dMan;

	public string[] dialogueLines;

	public bool isCutScene;

	private PlayerController thePlayer;

	// Use this for initialization
	void Start () {
		dMan = FindObjectOfType<DialogueManager> ();
		thePlayer = FindObjectOfType<PlayerController> ();
	}

	void OnTriggerStay2D(Collider2D other) {
		if(other.gameObject.name == "Player") {
			print ("collided");
			dialogueLaunch ();
		}
	}
		
	public void dialogueLaunch() {
		print ("dialogue launch");
		if(Input.GetKeyUp(KeyCode.Space) || isCutScene) {
			if(!dMan.dialogActive) {
				thePlayer.canMove = false;
				dMan.dialogLines = dialogueLines;
				dMan.currentLine = 0;
				dMan.ShowDialogue();
			}
		}
	}
}

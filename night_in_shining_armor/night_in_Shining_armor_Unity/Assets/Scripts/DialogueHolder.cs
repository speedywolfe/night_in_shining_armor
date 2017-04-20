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
			dialogueLaunch ();
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.name == "Player") {
			dMan.ShowPrompt ();
		}
	}

	void OnTriggerExit2D(Collider2D other){
		if (other.gameObject.name == "Player") {
			dMan.HidePrompt (); 
		}
	}
		
	public void dialogueLaunch() {
		if(Input.GetKeyDown(KeyCode.Space) || isCutScene) {
			if(!dMan.dialogActive) {
				if(isCutScene) {
					dMan.cutScene = true;
				}
				thePlayer.canMove = false;
				dMan.dialogLines = dialogueLines;
				dMan.currentLine = -1;
				dMan.ShowDialogue();
			}
		}
	}
}

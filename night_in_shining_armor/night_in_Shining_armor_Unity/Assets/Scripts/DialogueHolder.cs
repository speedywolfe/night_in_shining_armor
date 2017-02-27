using UnityEngine;
using System.Collections;

public class DialogueHolder : MonoBehaviour {

	public string dialogue;
	private DialogueManager dMan;

	public string[] dialogueLines;

	public bool isCutScene;
	public bool canStartQuest;
	public int questNumber;

	private PlayerController thePlayer;

	private QuestTrigger qTrig;

	// Use this for initialization
	void Start () {
		dMan = FindObjectOfType<DialogueManager> ();
		thePlayer = FindObjectOfType<PlayerController> ();
		qTrig = FindObjectOfType<QuestTrigger> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(isCutScene) {
			thePlayer.canMove = false;
		}
	}

	void OnTriggerStay2D(Collider2D other) {
		if(other.gameObject.name == "Player") {
			if(Input.GetKeyUp(KeyCode.Space) || isCutScene) {
//				dMan.ShowBox (dialogue);
				if(!dMan.dialogActive) {
					dMan.dialogLines = dialogueLines;
					dMan.currentLine = 0;
					dMan.ShowDialogue();
					if(canStartQuest) {
						StartAQuest ();
					}
				}
			}
		}
	}

	public void StartAQuest() {
		qTrig.ActivateQuest (questNumber);
	}
}

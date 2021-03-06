﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

	public GameObject dBox;
	public Text dText;

	public bool dialogActive;
	public bool cutScene;
	public bool dialogEnded = false;

	public string[] dialogLines;
	public int currentLine;

	private PlayerController thePlayer;	
	public GameObject dPrompt;

	// Use this for initialization
	void Start () {
		thePlayer = FindObjectOfType<PlayerController> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(dialogActive && Input.GetKeyDown(KeyCode.Space)) {

			currentLine++;
		}
		if(currentLine >= dialogLines.Length) {
			dBox.SetActive (false);
			dialogActive = false;

			currentLine = 0;
			thePlayer.canMove = true;
			if(cutScene) {
				dialogEnded= true;
			}
		}
		if (dialogActive) {
			dText.text = dialogLines [currentLine];
		}
	}

//	public void ShowBox(string dialogue) {
//		dialogActive = true;
//		dBox.SetActive (true);
//		dText.text = dialogue;
//	}

	public void ShowDialogue() {
		dialogActive = true;
		dBox.SetActive (true);

		thePlayer.canMove = false;
	}

	public void ShowPrompt() {
		dPrompt.SetActive (true);
	}

	public void HidePrompt() {
		dPrompt.SetActive (false);
	}
}

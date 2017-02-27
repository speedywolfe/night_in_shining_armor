using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestTrigger : MonoBehaviour {

	private QuestManager theQM;

	public bool startQuest;
	public bool endQuest;

	// Use this for initialization
	void Start () {
		theQM = FindObjectOfType<QuestManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ActivateQuest(int questNumber) {
		if(!theQM.questCompleted[questNumber]) {
			print (questNumber);
			if(startQuest && !theQM.quests[questNumber].gameObject.activeSelf) {
				theQM.quests [questNumber].gameObject.SetActive (true);
				theQM.quests [questNumber].StartQuest ();
			}
			if(endQuest && theQM.quests[questNumber].gameObject.activeSelf) {
				theQM.quests [questNumber].EndQuest ();	
			}
		}
	}
}

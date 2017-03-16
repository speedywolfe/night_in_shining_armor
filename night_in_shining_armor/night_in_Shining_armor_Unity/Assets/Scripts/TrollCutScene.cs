using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrollCutScene : MonoBehaviour {

	private PlayerController thePlayer;

	bool startCutScene;

	// Use this for initialization
	void Start () {
		thePlayer = FindObjectOfType<PlayerController> ();
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
		Debug.Log("inside troll touched");
//		ScreenFader sf = GameObject.FindGameObjectWithTag ("Fader").GetComponent<ScreenFader> ();
//		yield return StartCoroutine (sf.FadeToBlack ());
//		print ("After first yield");
//
//		yield return new WaitForSeconds (3);
//		print ("After three seconds");
//
//		yield return StartCoroutine (sf.FadeToClear());
//		print ("After last yield");
		//		Application.LoadLevel ("Pass_area");
		//		thePlayer.startPoint = "PassAreaRight";
	}
}

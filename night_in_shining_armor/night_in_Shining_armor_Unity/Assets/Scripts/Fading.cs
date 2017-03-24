using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fading : MonoBehaviour {

//	public Texture2D fadeOutTexture;
	public SpriteRenderer sr;

	public float fadeSpeed;
//	private int drawDepth = -1000;
	private float alpha = 0.0f;

	private bool fadeOut = false;
	private bool fadeIn = false;

	public void Awake() {
		sr = gameObject.GetComponent<SpriteRenderer>(); 
	}

	public void Update() {
		if (fadeOut) {
			alpha += (fadeSpeed + Time.deltaTime);
			alpha = Mathf.Clamp01 (alpha);

			if(alpha == 1.0f) {
				fadeOut = false;
			}
		}
		else if (fadeIn) {
			alpha -= fadeSpeed + Time.deltaTime;
			alpha = Mathf.Clamp01 (alpha);

			if(alpha == 0.0f) {
				fadeOut = false;
			}
		}

		//Draw Fade Texture
		sr.color = new Color (1f, 1f, 1f, alpha);
	}
		
	public void startFadeIn() {
		fadeIn = true;
	}

	public void startFadeOut() {
		fadeOut = true;
	}
}


//void OnGUI() {
//	if (fadeOut) {
//		alpha += (fadeSpeed + Time.deltaTime);
//		alpha = Mathf.Clamp01 (alpha);
//
//		if(alpha == 1.0f) {
//			fadeOut = false;
//		}
//	}
//	else if (fadeIn) {
//		alpha -= fadeSpeed + Time.deltaTime;
//		alpha = Mathf.Clamp01 (alpha);
//
//		if(alpha == 0.0f) {
//			fadeOut = false;
//		}
//	}
//
//	//Draw Fade Texture
//	GUI.color = new Color (GUI.color.r, GUI.color.g, GUI.color.b, alpha);
//	GUI.depth = drawDepth;
//	GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), fadeOutTexture);
//}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fading : MonoBehaviour {

	public Texture2D fadeOutTexture;

	public float fadeSpeed;
	private int drawDepth = -1000;
	private float alpha = 1.0f;
	private int fadeDir = -1;

	private bool fadeOut = false;
	private bool fadeIn = false;

	void OnGUI() {
		if (fadeOut) {
			print ("if fade out");
			alpha -= fadeDir * fadeSpeed * Time.deltaTime;
			alpha = Mathf.Clamp01 (alpha);

			GUI.color = new Color (GUI.color.r, GUI.color.g, GUI.color.b, alpha);
			GUI.depth = drawDepth;
			GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), fadeOutTexture);
//			fadeOut = false;
		}
		else if (fadeIn) {
			print ("if fade in");
			alpha += fadeDir * fadeSpeed * Time.deltaTime;
			alpha = Mathf.Clamp01 (alpha);

			GUI.color = new Color (GUI.color.r, GUI.color.g, GUI.color.b, alpha);
			GUI.depth = drawDepth;
			GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), fadeOutTexture);
//			fadeIn = false;
		}
	}
		
	public void startFadeIn() {
		print ("Within startFadeIn");
		fadeIn = true;
	}

	public void startFadeOut() {
		print ("Within startFadeOut");
		fadeOut = true;
	}
}
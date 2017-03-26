using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour {

	private GameObject Sword;

	public Sprite greatSword;
	public Sprite brokenSword;

	private Vector2 greatSwordSize = new Vector2 (0.28f , 1.39f);
	private Vector2 greatSwordOffset = new Vector2 (0.005712628f , 0.99f);

	private Vector2 brokenSwordSize = new Vector2 (0.19f , 0.67f);
	private Vector2 brokenSwordOffset = new Vector2 (0.0f , 0.6f);

	// Use this for initialization
	void Start () {
		Sword = GameObject.Find ("Sword");
	}

	public void setGreatSword() {
		Sword.GetComponent<SpriteRenderer> ().sprite = greatSword;
		Sword.GetComponent<BoxCollider2D> ().size = greatSwordSize;
		Sword.GetComponent<BoxCollider2D> ().offset = greatSwordOffset;
	}

	public void setBrokenSword() {
		Sword.GetComponent<SpriteRenderer> ().sprite = brokenSword;
		Sword.GetComponent<BoxCollider2D> ().size = brokenSwordSize;
		Sword.GetComponent<BoxCollider2D> ().offset = brokenSwordOffset;
	}
}

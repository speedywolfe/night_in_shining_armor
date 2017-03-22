using UnityEngine;
using System.Collections;

public class TrollController : MonoBehaviour {

//	private Vector3 moveDirection;

	private GameObject Enemy;
	private GameObject Player;
	private TrollCutScene TCut;
	private Vector2 velocity = new Vector2(5.0f, 5.0f);

	public float Speed;
	private bool stillMoving = true;

	// Use this for initialization
	void Start () {
		Enemy = GameObject.Find ("troll");
		Player = GameObject.Find("Player");
		TCut = FindObjectOfType<TrollCutScene> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (stillMoving) {
			velocity = new Vector2((transform.position.x - Player.transform.position.x) * Speed, (transform.position.y - Player.transform.position.y) * Speed);
			Enemy.GetComponent<Rigidbody2D> ().velocity = -velocity;
		}
		else {
			Enemy.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 0);
			Animator anim = Enemy.GetComponent<Animator> ();
			anim.enabled = false;
		}
	}

	void OnCollisionEnter2D(Collision2D other) {
		stillMoving = false;
		TCut.trollTouched ();
		TCut.startCutScene = true;
	}
}

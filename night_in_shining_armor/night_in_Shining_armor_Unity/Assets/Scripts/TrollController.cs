using UnityEngine;
using System.Collections;

public class TrollController : MonoBehaviour {

//	private Vector3 moveDirection;

	private GameObject Enemy;
	private GameObject Player;
	private TrollCutScene TCut;

	public float Speed;

	// Use this for initialization
	void Start () {
		Enemy = GameObject.Find ("troll");
		Player = GameObject.Find("Player");
		TCut = FindObjectOfType<TrollCutScene> ();
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 velocity = new Vector2((transform.position.x - Player.transform.position.x) * Speed, (transform.position.y - Player.transform.position.y) * Speed);
		Enemy.GetComponent<Rigidbody2D>().velocity = -velocity;
	}

	void OnCollisionEnter2D(Collision2D other) {
		TCut.trollTouched ();
		TCut.startCutScene = true;
	}
}

using UnityEngine;
using System.Collections;

public class TrollController2 : MonoBehaviour {

//	private Vector3 moveDirection;

	private GameObject Enemy;
	private GameObject Player;
	private Vector2 velocity = new Vector2(5.0f, 5.0f);

	public float Speed;
	private bool stillMoving = true;

	private PlayerController thePlayer;
	private doorController dControl;
	private EnemyHealthManager EHMan;

	// Use this for initialization
	void Start () {
		Enemy = GameObject.Find ("troll2");
		Player = GameObject.Find("Player");

		thePlayer = FindObjectOfType<PlayerController> ();
		dControl = thePlayer.GetComponent<doorController> ();

		EHMan = gameObject.GetComponent<EnemyHealthManager> ();
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

		print (EHMan.CurrentHealth);
		if(EHMan.CurrentHealth < 5) {
			dControl.clearingDoor = true;
		}
	}
}

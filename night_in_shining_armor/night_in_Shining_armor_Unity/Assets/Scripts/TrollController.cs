using UnityEngine;
using System.Collections;

public class TrollController : MonoBehaviour {

//	private Vector3 moveDirection;

	private GameObject Enemy;
	private GameObject Player;

	public float Speed;
	private float Range;

	// Use this for initialization
	void Start () {
		Enemy = GameObject.Find ("troll");
		Player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 velocity = new Vector2((transform.position.x - Player.transform.position.x) * Speed, (transform.position.y - Player.transform.position.y) * Speed);
		Enemy.GetComponent<Rigidbody2D>().velocity = -velocity;
//		Enemy.transform.Translate (Vector3.left * Time.deltaTime);
	}
}

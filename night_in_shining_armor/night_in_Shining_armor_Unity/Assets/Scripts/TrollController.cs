using UnityEngine;
using System.Collections;

public class TrollController : MonoBehaviour {

//	private Vector3 moveDirection;

	private GameObject Enemy;
	private GameObject Player;
	private DialogueHolder dHold;
	private DialogueManager dMan;
	private TrollCutScene TCut;

	public float Speed;
	private float Range;

	private PlayerController thePlayer;

	// Use this for initialization
	void Start () {
		Enemy = GameObject.Find ("troll");
		Player = GameObject.Find("Player");
		dHold = FindObjectOfType<DialogueHolder> ();
		dMan = FindObjectOfType<DialogueManager> ();
		TCut = FindObjectOfType<TrollCutScene> ();
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 velocity = new Vector2((transform.position.x - Player.transform.position.x) * Speed, (transform.position.y - Player.transform.position.y) * Speed);
		Enemy.GetComponent<Rigidbody2D>().velocity = -velocity;
	}

	void OnCollisionEnter2D(Collision2D other) {
		TCut.trollTouched ();

//		dHold.isCutScene = false;
//		dMan.dBox.SetActive (false);

		//yield return StartCoroutine (sf.FadeToClear());
//		Application.LoadLevel ("Pass_area");
//		thePlayer.startPoint = "PassAreaRight";
	}
}

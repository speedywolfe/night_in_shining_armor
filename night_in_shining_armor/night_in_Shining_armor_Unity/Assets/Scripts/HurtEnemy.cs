 using UnityEngine;
using System.Collections;

public class HurtEnemy : MonoBehaviour {

	private float baseDamage = 10.0f;
	private int damageToGive;
	public GameObject damageBurst;
	public Transform hitPoint;

	private PlayerController thePlayer;
	private int confidence;

	// Use this for initialization
	void Start () {
		thePlayer = FindObjectOfType<PlayerController> ();
	}
		
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Enemy") {
			int newDamage = ComputeDamage ();
			print (newDamage);
			other.gameObject.GetComponent<EnemyHealthManager>().HurtEnemy(newDamage);
			Instantiate (damageBurst, hitPoint.position, hitPoint.rotation); 
		}
			
	}

	int ComputeDamage() {
		confidence = thePlayer.gameObject.GetComponent<ConfidenceManager> ().playerCurrentConfidence;
		baseDamage = baseDamage * (confidence / 10);
		damageToGive = Mathf.CeilToInt(baseDamage);
		return damageToGive;
	}
}

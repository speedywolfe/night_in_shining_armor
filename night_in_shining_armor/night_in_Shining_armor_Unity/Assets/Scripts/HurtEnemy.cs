 using UnityEngine;
using System.Collections;

public class HurtEnemy : MonoBehaviour {

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
			other.gameObject.GetComponent<EnemyHealthManager>().HurtEnemy(newDamage);
			Instantiate (damageBurst, hitPoint.position, hitPoint.rotation); 
		}
			
	}

	int ComputeDamage() {
		confidence = thePlayer.gameObject.GetComponent<ConfidenceManager> ().playerCurrentConfidence;
		damageToGive = Mathf.CeilToInt(confidence / 10);
		if(damageToGive == 0) {
			damageToGive = 1;
		}
		return damageToGive;
	}
}

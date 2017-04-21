using UnityEngine;
using System.Collections;

public class EnemyHealthManager : MonoBehaviour {

	public int MaxHealth;
	public int CurrentHealth;
	public int RaiseConfidence;

	private GameObject thePlayer;

	// Use this for initialization
	void Start () {
		CurrentHealth = MaxHealth;
		thePlayer = GameObject.Find ("Player");
	}

	// Update is called once per frame
	void Update () {
		if (CurrentHealth <= 0) {
			Destroy (gameObject);
			thePlayer.GetComponent<ConfidenceManager>().ChangeConfidence(RaiseConfidence);
		}

	}

	public void HurtEnemy(int damageToGive){
		CurrentHealth = CurrentHealth - damageToGive;
	}


	public void SetMaxHealth(){
		CurrentHealth = MaxHealth;
	}
}

﻿using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

	public int playerMaxHealth;
	public int playerCurrentHealth;

	// Use this for initialization
	void Start () {
		playerCurrentHealth = playerMaxHealth;
	}
	
	// Update is called once per frame
	void Update () {

		if (playerCurrentHealth <= 0) {
			Application.LoadLevel(Application.loadedLevel);
			playerCurrentHealth = playerMaxHealth;
		}
	
	}

	public void HurtPlayer(int damageToGive){
		playerCurrentHealth = playerCurrentHealth - damageToGive;

	}


	public void SetMaxHealth(){
		playerCurrentHealth = playerMaxHealth;
	}

	public void BarelyAlive() {
		playerCurrentHealth = 1;
	}
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class UIManager : MonoBehaviour {

	public Slider healthBar;
	public Text HPText;
	public PlayerHealth playerHealth;

	public Slider ConfBar;
	public Text ConfText;
	public ConfidenceManager confidenceManager;

	private static bool UIExists;
	// Use this for initialization
	void Start () {
		if (!UIExists) {
			UIExists = true;
			DontDestroyOnLoad (transform.gameObject);
		} else {
			Destroy (gameObject);
		}

	}
	
	// Update is called once per frame
	void Update () {
		healthBar.maxValue = playerHealth.playerMaxHealth;
		healthBar.value = playerHealth.playerCurrentHealth;
		HPText.text = "HP: " + playerHealth.playerCurrentHealth + " / " + playerHealth.playerMaxHealth;

		ConfBar.maxValue = confidenceManager.playerMaxConfidence;
		ConfBar.value = confidenceManager.playerCurrentConfidence;
		ConfText.text = "Confidence: " + confidenceManager.playerCurrentConfidence + " / " + confidenceManager.playerMaxConfidence;
	}
}

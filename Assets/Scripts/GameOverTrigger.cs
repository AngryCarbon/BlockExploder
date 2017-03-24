using UnityEngine;
using System.Collections;

public class GameOverTrigger : MonoBehaviour {

	private LevelManager levelManager;

	void OnTriggerEnter2D (Collider2D collider) {
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		Debug.Log ("Trigger");
		levelManager.LoadLevel ("Lose");
	}
}

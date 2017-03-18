using UnityEngine;
using System.Collections;

public class GameOverTrigger : MonoBehaviour {

	public LevelManager levelManager;

	void OnTriggerEnter2D (Collider2D collider) {
		Debug.Log ("Trigger");
		levelManager.LoadLevel ("Win");
	}
}

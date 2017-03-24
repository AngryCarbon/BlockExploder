using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel (string name) {
		Debug.Log ("Load level requested: " + name);
		Application.LoadLevel (name);
	}
	
	public void LoadNextLevel () {
		Application.LoadLevel (Application.loadedLevel + 1);
	}
	
	public void QuitRequest () {
		Debug.Log ("Quit requested");
	}
}

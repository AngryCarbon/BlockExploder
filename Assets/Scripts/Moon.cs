using UnityEngine;
using System.Collections;

public class Moon : MonoBehaviour {

	public Paddle paddle;
	private Vector3 paddleToMoonVector;
	private bool hasStarted = false;

	// Use this for initialization
	void Start () {
		// Collect relative difference of position between the Moon and the paddle
		paddleToMoonVector = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (!hasStarted) {
			// Lock Moon relative to the paddle
			this.transform.position = paddle.transform.position + paddleToMoonVector;
			
			// On mouse click, launch ball
			if (Input.GetMouseButtonDown (0)) {
				hasStarted = true;
				Debug.Log ("You clicked the mouse button! Hurray!");
				this.rigidbody2D.velocity = new Vector2 (0f, 10f);
			}
		}
	}
}

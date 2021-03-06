﻿using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	public bool autoPlay = false;
	public float minX = 1F;
	public float maxX = 15F;
	
	private Moon moon;

	void Start () {
		moon = GameObject.FindObjectOfType<Moon> ();
	}

	// Update is called once per frame
	void Update () {
		if (!autoPlay) {
			MoveWithMouse ();
		} else {
			AutoPlay ();
		}
	}

	void AutoPlay () {
		Vector3 paddlePos = new Vector3 (0.5f, this.transform.position.y, 0f);
		Vector3 moonPos = moon.transform.position;
		paddlePos.x = Mathf.Clamp (moonPos.x, minX, maxX);
		this.transform.position = paddlePos;
	}

	void MoveWithMouse () {
		Vector3 paddlePos = new Vector3 (0.5f, this.transform.position.y, 0f);
		float mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;
		paddlePos.x = Mathf.Clamp (mousePosInBlocks, minX, maxX);
		this.transform.position = paddlePos;
	}
}
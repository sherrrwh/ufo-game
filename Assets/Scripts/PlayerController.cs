﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed;

	private Rigidbody2D rb2d;

	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
	}
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		Vector2 movemnet = new Vector2 (moveHorizontal,moveVertical);
		rb2d.AddForce(movemnet * speed);
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.gameObject.CompareTag("PickUp")) {
			other.gameObject.SetActive (false);
		}
	}
}

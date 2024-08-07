﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletScript : MonoBehaviour {
	private Rigidbody2D bullet;
	[SerializeField] private float speed = 5f;

	void Start () {
		bullet = GetComponent<Rigidbody2D> ();
		//Start moving the bullet
		bullet.velocity = new Vector2 (0, -speed);
	}
	void OnBecameInvisible () {
		//Destroy if not visible
		Destroy (gameObject);
	}
}

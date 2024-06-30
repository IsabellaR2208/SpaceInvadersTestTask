using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunkerScript : MonoBehaviour {
	const string ENEMY_BULLET = "EnemyBullet";
	const string PLAYER_BULLET = "PlayerBullet";
	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.gameObject.tag == ENEMY_BULLET || col.gameObject.tag == PLAYER_BULLET) {
			Destroy (gameObject);
			Destroy (col.gameObject);
		}
	}
}

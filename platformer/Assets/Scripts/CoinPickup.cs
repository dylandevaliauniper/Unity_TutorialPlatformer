﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour {
	public int value;

	private void OnTriggerEnter2D(Collider2D collision) {
		if (collision.GetComponent<PlayerController>() != null) {
			ScoreManager.addScore(value);
			Destroy(gameObject);
		}
	}
}

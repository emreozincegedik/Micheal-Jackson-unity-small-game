using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikescript : MonoBehaviour {

		private Player player;

	private void Start() {
		player=GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
		
	}

	private void OnTriggerEnter2D(Collider2D other) {
		if (other.CompareTag("Player"))
		{
				player.Damage(1);				
				StartCoroutine(player.Knockback(0.02f,1f,-player.transform.position));
		}
	}
}

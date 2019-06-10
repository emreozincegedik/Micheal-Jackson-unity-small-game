using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outofbounds : MonoBehaviour {

	private Player player;
	void Start () {
		player=GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
	}
	
	private void OnTriggerEnter2D(Collider2D other) {
		if (other.CompareTag("Player"))
		{
				player.Damage(5);
		}
	}
}

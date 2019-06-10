using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wingame : MonoBehaviour {

	
 public GameObject WinUI;
 private pausemenu psmn;
	
	void Start () {
		WinUI.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter2D(Collider2D other) { if (other.CompareTag("Player"))
		{
		WinUI.SetActive(true);}
	}
}

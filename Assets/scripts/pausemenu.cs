using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausemenu : MonoBehaviour {

	public GameObject PauseUI;
	public GameObject WinUI;
	

	public GameObject DieUI;
	

	private bool paused=false;

	private void Start() {
		PauseUI.SetActive(false);
	}


	private void Update() {
		if (Input.GetKeyDown(KeyCode.Escape)&&(WinUI.activeInHierarchy==true||DieUI.activeInHierarchy==true))
		{
				return;
		}
		if (Input.GetKeyDown(KeyCode.Escape))
		{
				paused=!paused;
		}
		if (paused)
		{
				PauseUI.SetActive(true);
				Time.timeScale=0;
		}
		if (!paused)
		{
				PauseUI.SetActive(false);
				Time.timeScale=1;
		}
		if (WinUI.activeInHierarchy==true)
		{
				Time.timeScale=0;
		}
	}


	public void Resume(){
		paused=false;
	}

	public void Restart(){
		Application.LoadLevel(Application.loadedLevel);		
		paused=false;
	}

	public void time(){
		Time.timeScale=0;
	}
}

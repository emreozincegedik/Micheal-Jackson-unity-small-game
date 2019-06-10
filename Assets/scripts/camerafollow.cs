using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour {

	private Vector2 velocity;

	public float smoothtimey;
	public float smoottimex;

	public bool bounds;

	public Vector3 mincampos;
	public Vector3 maxcampos;
	
	public GameObject player;
	void Start () {
		player=GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	private void FixedUpdate() {
		float posx=Mathf.SmoothDamp(transform.position.x,player.transform.position.x,ref velocity.x, smoottimex);

		float posy=Mathf.SmoothDamp(transform.position.y,player.transform.position.y,ref velocity.y, smoothtimey);

		transform.position=new Vector3(posx,posy,transform.position.z);

		if (bounds)
		{
				transform.position=new Vector3(Mathf.Clamp(transform.position.x,mincampos.x,maxcampos.x),Mathf.Clamp(transform.position.y,mincampos.y,maxcampos.y),Mathf.Clamp(transform.position.z,mincampos.z,maxcampos.z));
		}
	}

	public void setmincampos(){
mincampos=gameObject.transform.position;
	}
	public void setmaxcampos(){
maxcampos=gameObject.transform.position;
	}
}

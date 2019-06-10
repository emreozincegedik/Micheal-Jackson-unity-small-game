using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

	public float speed;
	public float jumpforce;
	private float moveinput;
	public bool facingRight=true; 
	
	private bool isgrounded;
	public Transform groundCheck;
	public float CheckRadius;
	public LayerMask whatisground;
	private int jumps=2;
	public int jumpvalue;

	public Rigidbody2D rb;

	void Start() {
		jumps=jumpvalue;
		rb=GetComponent<Rigidbody2D>();
	}

	void Update() {
		if (isgrounded==true)
		{
			jumps=1;
		}

		if (jumps>0&&Input.GetKeyDown(KeyCode.UpArrow))
		{
			rb.velocity=Vector2.up*jumpforce;
			jumps--;
			
		}
		else if (Input.GetKeyDown(KeyCode.UpArrow)&&jumps==0&&isgrounded==true)
		{
			rb.velocity=Vector2.up*jumpforce;
			jumps--;
		}
	}

	void FixedUpdate() {

		isgrounded=Physics2D.OverlapCircle(groundCheck.position, CheckRadius, whatisground);

		moveinput=Input.GetAxisRaw("Horizontal");
		rb.velocity=new Vector2(moveinput*speed,rb.velocity.y);
		if (facingRight==true&&moveinput>0)
		{
			Flip();
		}
		else if (facingRight==false&&moveinput<0)
		{
			Flip();
		}
	}

	private void Flip() 
	{ facingRight= !facingRight; transform.Rotate(0f, 180f, 0f); }

	
}


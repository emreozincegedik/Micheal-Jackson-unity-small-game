using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

public float Speed=2f;
public float jumppower=300f;
public bool grounded;
private Rigidbody2D rb2d;

public GameObject DieUI;

public int curhealth;
public int maxhealth=5;

private Animator anim;
	void Start () {
		rb2d=gameObject.GetComponent<Rigidbody2D>();
		anim=gameObject.GetComponent<Animator>();
		DieUI.SetActive(false);
		curhealth=maxhealth;
	}
	
	void Update () {
		anim.SetBool("Grounded",grounded);
		anim.SetFloat("Speed",Mathf.Abs(rb2d.velocity.x));
		if (Input.GetAxis("Horizontal")<-0.1f)
		{
				transform.localScale=new Vector2(2.200883f,2.200883f);
		}
		if (Input.GetAxis("Horizontal")>0.1f)
		{
				transform.localScale=new Vector2(-2.200883f,2.200883f);
		}
		if (Input.GetKeyDown(KeyCode.UpArrow)&&grounded)
		{
				rb2d.AddForce(jumppower*Vector2.up);
				
		}

		if (curhealth>maxhealth)
		{
				curhealth=maxhealth;
		}
		
		if (curhealth<=0)
		{
				Die();
		}
		
	}
	private void FixedUpdate() {
		float h=Input.GetAxis("Horizontal");
		rb2d.velocity=new Vector2(h*Speed,rb2d.velocity.y);
	}

	void Die(){
		DieUI.SetActive(true);
		Time.timeScale=0;
	}

	public void Damage(int dmg){
		curhealth-=dmg;
		gameObject.GetComponent<Animation>().Play("damaged");
	}

public IEnumerator Knockback(float knockdur,float knockbackpwr,Vector3 knockbackdir)
{
	float timer=0;
	while (knockdur>timer)
	{
			timer+=Time.deltaTime;
			/*rb2d.AddForce(new Vector3(knockbackdir.x*(-100),knockbackpwr*knockbackdir.y,transform.position.z));*/
			rb2d.velocity=new Vector3(knockbackdir.x*(-100),knockbackpwr*knockbackdir.y,transform.position.z);
	}
	yield return 0;
}







}

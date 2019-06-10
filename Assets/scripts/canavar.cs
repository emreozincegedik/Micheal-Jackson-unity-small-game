using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canavar : MonoBehaviour {

				private Player player;
				private Rigidbody2D rb2d;

				public float speed = 1f;
			
        void Start () {
           

						player=GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
						rb2d=gameObject.GetComponent<Rigidbody2D>();
						rb2d.velocity=new Vector2(speed,rb2d.velocity.y);
						
						time=timer;
						moveright=scale;
        }
       public float timer=3f;
			 private float time;
			 private float moveright;
			 public float scale=0.4923f;
        // Update is called once per frame
        void Update () {
					time-=Time.deltaTime;
					if (time<=0)
					{
						moveright=-moveright;
							speed=-speed;
							time=timer;
							transform.localScale=new Vector2(moveright,scale);
							rb2d.velocity=new Vector2(speed,rb2d.velocity.y);
					}
					transform.localScale=new Vector2(moveright,scale);
							rb2d.velocity=new Vector2(speed,rb2d.velocity.y);
           
        }

				private void OnTriggerEnter2D(Collider2D other) {
		if (other.CompareTag("Player"))
		{
				player.Damage(1);				
				StartCoroutine(player.Knockback(0.05f,1f,-player.transform.position));
		}
	
	}

	

}

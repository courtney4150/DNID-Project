using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
	private Rigidbody2D rb2D;
	private float moveSpeed; 
	private float jumpForce; 
	private bool isJumping;
	private float moveHorizontal; 
	private float moveVertcial;

	void Start(){
		rb2D = gameObject.GetComponent<Rigidbody2D>();
		moveSpeed = 100f; 
		jumpForce = 1500f; 
		isJumping = false; 
	}
	
	
	void Update(){
		moveHorizontal = Input.GetAxisRaw("Horizontal");
		moveVertcial = Input.GetAxisRaw("Vertical");

	}

	void FixedUpdate(){
		Vector2 velocity = rb2D.velocity;
    	velocity.x = moveHorizontal * moveSpeed * Time.fixedDeltaTime;
    	rb2D.velocity = velocity;
		if(moveHorizontal > 0.1f || moveHorizontal < -0.1f){
			rb2D.AddForce(new Vector2(moveHorizontal * moveSpeed, 0f));
		}

		if(!isJumping && moveVertcial > 0.1f){
			rb2D.AddForce(new Vector2(0f, moveVertcial * jumpForce));
		}	
	}

	void OnTriggerEnter2D(Collider2D collision){
		if(collision.gameObject.tag == "Platform"){
			isJumping = false;
		}
	}

	void OnTriggerExit2D(Collider2D collision){
		if(collision.gameObject.tag == "Platform"){
			isJumping = true;
		}
	}
}

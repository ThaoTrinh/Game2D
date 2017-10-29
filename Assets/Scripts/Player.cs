using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {


	public float speed;
	public float jump;
	bool facingRight;
	bool standGround;


	Rigidbody2D body; //Ket noi cac thuoc tinh vat li voi player 
	Animator Anim;

	// Use this for initialization
	void Start () {
		//Dat thuoc tinh Bat dau game
		body = GetComponent<Rigidbody2D>();	// tao thuoc tinh trong AddComponent lam ro bien body la thuoc tinh rigidbody2D
		Anim = GetComponent<Animator>();
		facingRight = true;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float move = Input.GetAxis("Horizontal");
		body.velocity = new Vector2(move*speed,body.velocity.y); // giu nguyen truc y
		//truc x khi nhan D thi move = -1 speed duong nen x am va se di chuyen sang trai
		if(move > 0&& !facingRight){
			flip();
		}
		else if(move < 0 && facingRight){
			flip();
		}

		if(Input.GetKey(KeyCode.Space)){
			if(standGround){
				standGround = false; // neu dang cham dat chan nhay len nen se khong cham nua
				body.velocity = new Vector2(body.velocity.x , jump); //nhay len x khong thay doi y = jump
			}
		}
		Anim.SetFloat("speed", Mathf.Abs(move));
	}

	void flip(){
		facingRight =!facingRight;
		Vector3 scale = transform.localScale;//toa do hien tai trong transform cua character 
		scale.x *= -1; //thay doi huong quay mat sang trai hay phai
		transform.localScale = scale; //thay doi toa do hien tai cua character
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if(other.gameObject.tag == "Ground"){ // doi tuong ma va cham voi 1 cai ma cai do la ground
			standGround = true;//thi dang dung tren mat dat
		}
		else standGround = false;
	}
}


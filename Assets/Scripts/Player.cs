using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{


      public float speed;
      public float jump;
      bool facingRight;
      bool standGround = true;

//Cac bien de ban

     public Transform bulletLocal; // vi tri vien dan duoc ban ra
      public GameObject bullet; //doi tuong
      float fireTime = 0.5f; //0.5s ban 1 lan
      float nextFire = 0;
      bool shoot = false;



      Rigidbody2D body; //Ket noi cac thuoc tinh vat li voi player 
      Animator Anim;
      // Use this for initialization
      void Start() {
            //Dat thuoc tinh Bat dau game
            body =gameObject.GetComponent<Rigidbody2D>(); // tao thuoc tinh trong AddComponent lam ro bien body la thuoc tinh rigidbody2D
            Anim =gameObject.GetComponent<Animator>();
            facingRight = true;
      }

      // Update is called once per frame
      void FixedUpdate() {
            float move = Input.GetAxis("Horizontal");

      		    Anim.SetFloat("speed", Mathf.Abs(move));
             Anim.SetBool("ground", standGround);
              Anim.SetBool("shoot", shoot);

			 body.velocity = new Vector2(move * speed, body.velocity.y);//truc x khi nhan D thi move = -1 speed duong nen x am va se di chuyen sang trai
 		if (move > 0 && !facingRight) {
                   flip();
             } else if (move < 0 && facingRight) {
                   flip();
             }
            
             if (move > 0 && !facingRight) {
                   flip();
             } else if (move < 0 && facingRight) {
                   flip();
             }

             if(Input.GetKeyDown(KeyCode.Space)){
               if (standGround) {
                   standGround = false; // neu dang cham dat chan nhay len nen se khong cham nua
				  body.velocity = new Vector2(body.velocity.x,jump );

              }
             }


             //ban tu ban phim
             if(Input.GetKey("z")){
                   shoot = true;
                   fireBullet();
             }
             else {
                   shoot = false;
             }


      }

      void flip() {
            facingRight = !facingRight;
            Vector3 scale = transform.localScale;//toa do hien tai trong transform cua character 
            scale.x *= -1; //thay doi huong quay mat sang trai hay phai
            transform.localScale = scale; //thay doi toa do hien tai cua character
      }

      void OnCollisionEnter2D(Collision2D other) {
            if (other.gameObject.tag == "Ground") { // doi tuong ma va cham voi 1 cai ma cai do la ground
                  standGround = true;//thi dang dung tren mat dat
            } else standGround = false;
      }


      //Chuc nang ban
      void fireBullet(){
            if(Time.time > nextFire){
                  nextFire = Time.time + fireTime;
                  if(facingRight){
                        Instantiate(bullet, bulletLocal.position, Quaternion.Euler(new Vector3(0,0,0)));
                  }
                  else {
                        Instantiate(bullet, bulletLocal.position, Quaternion.Euler(new Vector3(0,0,180)));
                        //quay nguoc vien dan
                  }
            }
      }
}


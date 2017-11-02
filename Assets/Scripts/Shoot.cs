using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

      public float bulletSpeed;
      Rigidbody2D body;

	  void Awake(){
            body = GetComponent<Rigidbody2D>();

			if(transform.localRotation.z>0){
            	body.AddForce(new Vector2(-1, 0) * bulletSpeed, ForceMode2D.Impulse); 
			}
			else{
				body.AddForce(new Vector2(1, 0) * bulletSpeed, ForceMode2D.Impulse); 
			}
			//Vector2(1, 0) * bulletSpeed : di chuyen theo chieu ngang huong qua ben phai
			//ForceMode2D.Impulse:  tao ra xung luc 
			//=> lam cho vien dan lap tuc bay di

      }//Duoc goi truoc khi start. khi chuong trinh khong chay thi awake van duoc goi mac du start thi khong

      // Use this for initialization
      void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//Tao chuc nang vien dan dung lai

	public void removeForce(){
		body.velocity = new Vector2(0,0);
	}
}

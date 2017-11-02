using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHit : MonoBehaviour {


	Shoot myPC;
	public GameObject bulletExplosion;
   public float weaponDamage;
	void Awake(){
		myPC = GetComponentInParent<Shoot>();
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.tag == "Shootable"){
			myPC.removeForce();
			Instantiate(bulletExplosion,transform.position,transform.rotation);
			Destroy(gameObject); //phas huy doi tuong khi va cham
        if (other.gameObject.layer == LayerMask.NameToLayer("enemy"))
        {
           enemyHealth hurtEnemy = other.gameObject.GetComponent<enemyHealth>();
            hurtEnemy.addDamage(weaponDamage);
        }
		}
	}//vua bat dau va cham

	void OnTriggerStay2D(Collider2D other){
		if(other.gameObject.tag == "Shootable"){
			myPC.removeForce();
			Instantiate(bulletExplosion,transform.position,transform.rotation);
			Destroy(gameObject); //phas huy doi tuong khi va cham
			 if (other.gameObject.layer == LayerMask.NameToLayer("enemy"))
        {
           enemyHealth hurtEnemy = other.gameObject.GetComponent<enemyHealth>();
            hurtEnemy.addDamage(weaponDamage);
        }
		}
	}//khi vat the di xuyen qua vat bi qua cham
}

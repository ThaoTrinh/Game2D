using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyRun : MonoBehaviour {
    Rigidbody2D rbEnemy;

    Animator arEnemy;

    //public static float enemySpeed=50;
    public static float enemySpeed = 50;

      public static bool facingLeft = true;
      // Use this for initialization
      void Start () {
        rbEnemy = GetComponent<Rigidbody2D>();
            arEnemy = GetComponent<Animator>();

      }
	
	// Update is called once per frame
	void Update () {
        rbEnemy.velocity = new Vector2(facing()*enemySpeed, rbEnemy.velocity.y);
            arEnemy.SetFloat("speed", enemySpeed);
            GetComponent<SpriteRenderer>().flipX = facingLeft;
      }

      float facing(){
            return facingLeft ? -1 : 1;
      }
}

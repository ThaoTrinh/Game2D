using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyRun : MonoBehaviour {
    Rigidbody2D rbEnemy;
    public static float speed=15;
	// Use this for initialization
	void Start () {
        rbEnemy = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        rbEnemy.velocity = new Vector2(-speed, rbEnemy.velocity.y);
	}
}

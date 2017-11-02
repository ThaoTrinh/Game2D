using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour {
    public float maxHealth;
    float currentHealth;
    // Use this for initialization
    void Start() {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update() {

    }
    public void addDamage(float dame)
    {
        currentHealth -= dame;
        if (currentHealth <= 0) makeDead();
    }
    void makeDead()
    {
        Destroy(gameObject);
        // public float weaponDamage
        //them vao bullethit: ham ontriggerenter2d va stay2d
        //if (other.gameObject.layer == LayerMask.NameToLayer("enemy"))
        //{
        //    enemyHealth hurtEnemy = other.gameObject.GetComponent<enemyHealth>();
        //    hurtEnemy.addDamage(weaponDamage);
        //}
    }


}

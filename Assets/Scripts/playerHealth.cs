using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerHealth : MonoBehaviour {
    public float maxHealth;
    float currentHealth;
    public GameObject bloodEffect;
	// Use this for initialization

    //UI
    public Slider playerHealthSlider;


	void Start () {
        currentHealth = maxHealth;
            playerHealthSlider.maxValue = maxHealth; //max thanh slider
            playerHealthSlider.value = maxHealth; //vi trong giao dien da keo value len max
             
      }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void addDamage(float damage)
    {
        if (damage <= 0) return;
        currentHealth -= damage;
            playerHealthSlider.value = currentHealth; //thanh mau bi giam dan theo curhealthy

            if (currentHealth <= 0) makeDead();
    }
    void makeDead()
    {
        Instantiate(bloodEffect, transform.position, transform.rotation);
        Destroy(gameObject);
        Application.LoadLevel("gameover");
        // public float weaponDamage
        //them vao bullethit: ham ontriggerenter2d va stay2d
        //if (other.gameObject.layer == LayerMask.NameToLayer("enemy"))
        //{
        //    enemyHealth hurtEnemy = other.gameObject.GetComponent<enemyHealth>();
        //    hurtEnemy.addDamage(weaponDamage);
        //}
    }
    public void addHealth(float healthAmount)
    {
        currentHealth += healthAmount;
        if (currentHealth > maxHealth)
            currentHealth = maxHealth;
        playerHealthSlider.value = currentHealth;
    }
}

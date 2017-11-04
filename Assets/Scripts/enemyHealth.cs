using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyHealth : MonoBehaviour {
    public float maxHealth;
    float currentHealth;
      // Use this for initialization


    //enemy die
    public GameObject enemyHealthEF;

    // health enemy

    public Slider enemyHealthSlider;
    //enemy chet ra vien mau
    public bool drop;
    public GameObject theDrop;

    void Start() {
        currentHealth = maxHealth;
            enemyHealthSlider.maxValue = maxHealth;
            enemyHealthSlider.value = maxHealth;
    }

    // Update is called once per frame
    void Update() {

    }
    public void addDamage(float dame)
    {
            enemyHealthSlider.gameObject.SetActive(true); //dau tick ngay tai o enemyheath
            //vi no chi xuat hien khi co dan va cham vao
            
            currentHealth -= dame;
            enemyHealthSlider.value = currentHealth;
            if (currentHealth <= 0) makeDead();
    }
    void makeDead()
    {
        gameObject.SetActive(false);
        Instantiate(enemyHealthEF, transform.position, transform.rotation);
        if(drop)
        {
            Instantiate(theDrop, transform.position, transform.rotation);
        }
    }


}

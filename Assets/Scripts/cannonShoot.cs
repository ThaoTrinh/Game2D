using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonShoot : MonoBehaviour {
    public GameObject theBom;
    public Transform shootForm;
    public float shootTime;
    float nextShoot = 0f;
    Animator cannonAnim;

    private void Awake()
    {
        cannonAnim = GetComponentInChildren<Animator>();
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.tag=="Player"&&Time.time>nextShoot)
        {
            nextShoot = Time.time + shootTime;
            Instantiate(theBom, shootForm.position, Quaternion.identity);
            cannonAnim.SetTrigger("cannonShoot");
        }
    }
}

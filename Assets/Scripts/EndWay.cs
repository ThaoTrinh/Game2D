using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndWay : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerExit2D(Collider2D EndWay)
    {
        if(EndWay.gameObject.tag =="Ground")
        {
            enemyRun.speed *= -1;
        }
    }
}

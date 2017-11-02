using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyBullet : MonoBehaviour {

      public float timeLive;
      // Use this for initialization
      void Start () {
            Destroy(gameObject, timeLive);
      }
	
	// Update is called once per frame
	void Update () {
		
	}
}

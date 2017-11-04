using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomController : MonoBehaviour {
    public float bomSpeedHigh;
    public float bomSpeedLow;
    public float bomAngle;
    Rigidbody2D cannonRB;
    void Awake()
    {
        cannonRB = GetComponent<Rigidbody2D>();
    }
	// Use this for initialization
	void Start () {
        cannonRB.AddForce(new Vector2(Random.Range(-bomAngle, bomAngle), Random.Range(bomSpeedLow, bomSpeedHigh)),ForceMode2D.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

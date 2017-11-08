using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraGo : MonoBehaviour {

	public Transform target;
	public float smothing; //bien giup camera mịn hon

	Vector3 offset; //la 1 vecto chi tu vi tri cua camera sang nhan vat

	float lowY; //vi tri thap nhat cua camera. khi nhan vat bi roi thi camera khong di theo nua
	
	// Use this for initialization
	void Start () {
		offset = transform.position - target.position; //luon khong thay doi khi di chuyen
		lowY = transform.position.y; //transform.position la vi tri camera
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 CameraAfter = target.position +offset; //vi tri camera luc sau

		transform.position = Vector3.Lerp(transform.position,CameraAfter,smothing*Time.deltaTime);

		if(transform.position.y<lowY){
			 transform.position = new Vector3(transform.position.x,lowY,transform.position.z);
		}

		if(target.position.y<lowY - 2000){
			  Application.LoadLevel("gameover");
		}
		
	}
}

﻿using UnityEngine;
using System.Collections;

public class Tower : MonoBehaviour 
{
	//THe Bullet
	public GameObject bulletPrefab;

	// Rotation Speed
	public float rotationSpeed = 35;
	
	void Update() 
	{
		transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed, Space.World);
	}

	void OnTriggerEnter(Collider co)
	{
		if (co.GetComponent<Monster>()) 
		{
			GameObject g = (GameObject)Instantiate(bulletPrefab,transform.position,Quaternion.identity);
			g.GetComponent<Bullet>().target = co.transform;
		}
	}
	
}

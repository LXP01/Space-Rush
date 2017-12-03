using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1_Move : MonoBehaviour {

	public Rigidbody rb;
	public float force = 200f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate()
	{
		rb.AddForce(0, force * Time.deltaTime, 0, ForceMode.VelocityChange);
	}
}

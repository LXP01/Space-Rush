using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShot : MonoBehaviour {

private Rigidbody rb;
public float speed;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		rb.velocity = transform.up * speed;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

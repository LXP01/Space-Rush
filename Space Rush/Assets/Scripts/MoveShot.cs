using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShot : MonoBehaviour {

private Rigidbody rb;
public float speed;
public GameObject Shot;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		rb.velocity = transform.up * speed;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (rb.position.x >= 200 || rb.position.x <= -200 || rb.position.y >= 200 || rb.position.y <= -200) Destroy(Shot);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Controller : MonoBehaviour {

	//public Rigidbody rb;
	public float force = 200f;
	public Transform Player;
	Quaternion nQuaternion;
	float m_Speed = 50;
		

	// Use this for initialization
	void Start () {
		//rb = GetComponent<Rigidbody>();
		nQuaternion = new Quaternion();
	}
	
	// Update is called once per frame
	void Update () {
		
		Vector2 positionOnScreen = Camera.main.WorldToViewportPoint(transform.position);
    	Vector2 PlayerOnScreen = (Vector2)Player.transform.position;
    	float angle = AngleBetweenTwoPoints(positionOnScreen, PlayerOnScreen);
    	transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle+90));
		//rb.AddForce(0, force * Time.deltaTime, 0, ForceMode.VelocityChange);
	}

	float AngleBetweenTwoPoints(Vector3 angle1, Vector3 angle2)
   	{return Mathf.Atan2(angle1.y - angle2.y, angle1.x - angle2.x) * Mathf.Rad2Deg; }
}

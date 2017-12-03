using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Controller : MonoBehaviour {

	public Transform Player;
	Quaternion nQuaternion;
	float m_Speed = 1.0f;
	//public int rotationDamping = 3;
	

	// Use this for initialization
	void Start () {
		nQuaternion = new Quaternion();
	}
	
	// Update is called once per frame
	void Update () {
		/*Vector3 positionOnScreen = Player.position - transform.position;
		transform.rotation = Quaternion.LookRotation(positionOnScreen);
		var dir = Player.position - transform.position;
     	var rotation = Quaternion.LookRotation(dir);
     	/*transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * rotationDamping);
		transform.rotation = Quaternion.FromToRotation(dir, Player.position);*/

		nQuaternion.SetFromToRotation(transform.position, Player.position);
		transform.position = Vector3.Lerp(transform.position, Player.position, m_Speed * Time.deltaTime);
		transform.rotation = nQuaternion * transform.rotation;
	}

	
}

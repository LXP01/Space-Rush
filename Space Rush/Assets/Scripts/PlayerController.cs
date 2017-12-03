using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody rb;
    public float force = 200f;
    public Transform Player;

    public float x = 0f, y = 0f;

    public GameObject shot;
    public Transform shotspawn;
    public float fireRate;
    private float nextFire;

    void Update()
    {
        if (Input.GetMouseButton(0) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotspawn.position, shotspawn.rotation);
        }
        Debug.Log(Player.position);
    }


    void FixedUpdate()
    {


        y = Player.position.y; x = Player.position.x;

        if (Input.GetKey("d"))
        {
            if (Player.position.x >= 100) { return; }
            else { rb.AddForce(force * Time.deltaTime, 0, 0, ForceMode.VelocityChange); }
        }
        if (Input.GetKey("a"))
        {
            if (Player.position.x <= -100) { return; }
            rb.AddForce(-force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("w"))
        {
            if (Player.position.y >= 70) { return; }
            rb.AddForce(0, force * Time.deltaTime, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("s"))
        {
            if (Player.position.y <= -70) { return; }
            rb.AddForce(0, -force * Time.deltaTime, 0, ForceMode.VelocityChange);
        }


           
    }


    }



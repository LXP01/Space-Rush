using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {


    // Update is called once per frame
    void Update()
    {


        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position; //Subtracting player position with mous position


        float rot = Mathf.Atan2(difference.y, difference.x); * Mathf.Rad2Deg; //find angle
        transform.rotation = Quaternion.Euler(0f,0f,0+rot);



        Debug.Log(rot);
        //Debug.Log(Input.mousePosition);
    }
}

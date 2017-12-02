using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {


    // Update is called once per frame
    void Update()
    {


        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position; //Subtracting player position with mouse position
        difference.Normalize();
        Vector3 rotation1;
        


        float rot = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg; //find angle
        rotation1.x = 0f; rotation1.y = 0f; rotation1.z = 0+rot;
        transform.Rotate(rotation1);

        // Debug.Log(rot);
        Debug.Log(Input.mousePosition);
    }
}

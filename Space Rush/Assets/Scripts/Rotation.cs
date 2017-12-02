using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {




   void Update()
   {
       Vector2 positionOnScreen = Camera.main.WorldToViewportPoint(transform.position);
       Vector2 mouseOnScreen = (Vector2)Camera.main.ScreenToViewportPoint(Input.mousePosition);
       float angle = AngleBetweenTwoPoints(positionOnScreen, mouseOnScreen);
       transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle+90));
   }

   float AngleBetweenTwoPoints(Vector3 angle1, Vector3 angle2)
   {return Mathf.Atan2(angle1.y - angle2.y, angle1.x - angle2.x) * Mathf.Rad2Deg; }
   
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiling : MonoBehaviour {

    // OBEN UND UNTEN FEHLT NOCH UND MUSS NOCH SCHÖNER WERDEN

    public int ofsetX = 2;
    public bool hasARightBuddy = false;
    public bool hasALeftBuddy = false;
    public bool reverseScale = false;
    private float spriteWidth = 0f;
    private Camera cam;
    private Transform myTransform;

    void Awake()
    {
        cam = Camera.main;
        myTransform = transform;
    }
    void Start()
    {
        SpriteRenderer sRenderer = GetComponent<SpriteRenderer>();
        spriteWidth = sRenderer.sprite.bounds.size.x;
    }
    void Update()
    {
        if (hasALeftBuddy == false || hasARightBuddy == false)
        {
            float camHorizontalExtend = cam.orthographicSize * Screen.width/Screen.height;
            float edgeVisiblePositionRight = (myTransform.position.x + spriteWidth / 2) - camHorizontalExtend;
            float edgeVisiblePositionLeft = (myTransform.position.x - spriteWidth / 2) + camHorizontalExtend;
            if (cam.transform.position.x >= edgeVisiblePositionRight - ofsetX && hasARightBuddy == false)
            {
                MakeNewBuddy(10);
                hasARightBuddy = true;
            }
            else if (cam.transform.position.x <= edgeVisiblePositionLeft + ofsetX && hasALeftBuddy == false)
            {
                MakeNewBuddy(-10);
                hasALeftBuddy = true;
            }
        }
    }
    void MakeNewBuddy(int RightorLeft)
    {
        Vector3 newPosition = new Vector3(myTransform.position.x + spriteWidth * RightorLeft, myTransform.position.y, myTransform.position.z);
        Transform newBuddy = Instantiate(myTransform, newPosition, myTransform.rotation) as Transform;
        if (reverseScale == true)
        {
            newBuddy.localScale = new Vector3(newBuddy.localScale.x * -1, newBuddy.localScale.y, newBuddy.localScale.z);
        }
        newBuddy.parent = myTransform.parent;
        if (RightorLeft > 0)
        {
            newBuddy.GetComponent<Tiling>().hasALeftBuddy = true;
        }
        else
        {
            newBuddy.GetComponent<Tiling>().hasARightBuddy = true;
        }
    }
}

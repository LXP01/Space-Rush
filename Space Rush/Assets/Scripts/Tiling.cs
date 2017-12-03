using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(SpriteRenderer))]


public class Tiling : MonoBehaviour {

    public int offset = 2;
    public bool leftBuddy = false, rightBuddy = false, skyBuddy = false, groundBuddy = false;
    public bool reverseX = false;
    public bool reverseY = false;

    private float spriteWidth = 0f,spriteHeight = 0f;
    private Camera cam;
    private Transform trans;

    private void Awake()
    {
        cam = Camera.main;
        trans = transform;
    }
    private void Start()
    {
        SpriteRenderer sRenderer = GetComponent<SpriteRenderer>();
        spriteWidth = sRenderer.sprite.bounds.size.x;
        spriteHeight = sRenderer.sprite.bounds.size.y;
    }
    private void Update()
    {
        if(leftBuddy ==false || rightBuddy == false || skyBuddy == false || groundBuddy == false)
        {
            float camHextend = cam.orthographicSize * Screen.width / Screen.height;
            float camVextend = cam.orthographicSize * Screen.height/Screen.width;

            float edgeVisiblePosRight = (trans.position.x + spriteWidth / 2) - camHextend;
            float edgeVisiblePosLeft = (trans.position.x + spriteWidth / 2) + camHextend;
            float edgeVisiblePosSky = (trans.position.y + spriteHeight / 2) - camVextend;
            float edgeVisiblePosGround = (trans.position.y + spriteHeight / 2) + camVextend;

            if(cam.transform.position.x >= edgeVisiblePosRight - offset && rightBuddy==false)
            {
                MakeNewBuddyX(1);
                rightBuddy = true;
            }
            else if(cam.transform.position.x <= edgeVisiblePosLeft + offset && leftBuddy == false)
            {
                MakeNewBuddyX(-1);
                leftBuddy = true;
            }
            else if(cam.transform.position.y >= edgeVisiblePosSky - offset && skyBuddy == false)
            {
                MakeNewBuddyY(1);
                skyBuddy = true;
            }
            else if(cam.transform.position.y <= edgeVisiblePosGround + offset && groundBuddy == false)
            {
                MakeNewBuddyY(-1);
                groundBuddy = true;
            }
        }
    }
    void MakeNewBuddyX(int LoR)
    {
        Vector3 newPos = new Vector3(trans.position.x + spriteWidth * LoR, trans.position.y, trans.position.z);
        Transform newBuddyX = Instantiate(trans,newPos,trans.rotation) as Transform;
        if (reverseX == true) { newBuddyX.localScale = new Vector3(newBuddyX.localScale.x * -1, newBuddyX.localScale.y, newBuddyX.localScale.z); }
        newBuddyX.parent = trans.parent;
        if (LoR > 0)
        {newBuddyX.GetComponent<Tiling>().leftBuddy = true;}
        else if(LoR < 0) { newBuddyX.GetComponent<Tiling>().rightBuddy = true; }
    }
    void MakeNewBuddyY(int SoG)
    {
        Vector3 newPos = new Vector3(trans.position.x + spriteWidth * SoG, trans.position.y, trans.position.z);
        Transform newBuddyY = Instantiate(trans, newPos, trans.rotation) as Transform;
        if (reverseY == true) { newBuddyY.localScale = new Vector3(newBuddyY.localScale.x * -1, newBuddyY.localScale.y, newBuddyY.localScale.z); }
        newBuddyY.parent = trans.parent;
        if (SoG > 0)
        { newBuddyY.GetComponent<Tiling>().skyBuddy = true; }
        else if (SoG < 0) { newBuddyY.GetComponent<Tiling>().groundBuddy = true; }
    }
}

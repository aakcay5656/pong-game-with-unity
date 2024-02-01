using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSetup : MonoBehaviour
{

    public Camera mainCam;

    public Transform Player1;
    public Transform Player2;

    public BoxCollider2D topWall;
     public BoxCollider2D bottomWall;
     public BoxCollider2D leftWall;
     public BoxCollider2D rightWall;
    
    

    // Update is called once per frame
    void Update()
    {
        topWall.size= new Vector2(mainCam.ScreenToWorldPoint (new Vector3 (Screen.width*2f,0f,0f)).x,1f);
        topWall.offset = new Vector2(0f,mainCam.ScreenToWorldPoint(new Vector3(0f,Screen.height,0f)).y+0.5f);

         bottomWall.size= new Vector2(mainCam.ScreenToWorldPoint (new Vector3 (Screen.width*2f,0f,0f)).x,1f);
        bottomWall.offset = new Vector2(0f,mainCam.ScreenToWorldPoint(new Vector3(0f,0f,0f)).y-0.5f);

         leftWall.size= new Vector2(1f,mainCam.ScreenToWorldPoint (new Vector3 (0f,Screen.height*2f,0f)).y);
        leftWall.offset = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(0f,0f,0f)).x - 0.5f,0f);

         rightWall.size= new Vector2(1f,mainCam.ScreenToWorldPoint (new Vector3 (0f,Screen.height*2f,0f)).y);
        rightWall.offset = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width,0f,0f)).x + 0.5f,0f);


        Player1.position = new Vector3(mainCam.ScreenToWorldPoint(new Vector3(75f, 0f, 0f)).x, Player1.position.y, Player1.position.z);
         Player2.position = new Vector3(mainCam.ScreenToWorldPoint(new Vector3(Screen.width-75f, 0f, 0f)).x, Player2.position.y, Player2.position.z);
    }
}

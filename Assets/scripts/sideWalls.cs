
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sideWalls : MonoBehaviour
{

 GameObject g;
AudioSource ses;

 void Start() {
    g = GameObject.FindWithTag("Finish");
    ses=GetComponent<AudioSource>();
}
 void OnTriggerEnter2D(Collider2D coll)
    {
        
        if (coll.name == "Ball")
        {
           string  a = transform.name;
           ses.Play();
           g.GetComponent<gameManager>().Score(a);
           coll.GetComponent<ballMove>().resetBall();

           
        }        
    }




}

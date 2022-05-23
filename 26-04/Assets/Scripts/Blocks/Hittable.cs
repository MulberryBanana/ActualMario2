using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hittable : MonoBehaviour
{
   
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //Rigidbody2D rigidbody2D = other.gameObject.GetComponent<Rigidbody2D>();
            var normal = other.contacts[0].normal;
            if (normal.y > 0) { //if the bottom side hit something 
                //Debug.Log ("You Hit the floor");
                ProcessHit();
            }
            if (normal.y < 0) { //if the top side hit something
                //Debug.Log ("You Hit the roof");
            }    
        }
    }

    protected virtual void ProcessHit()
    {
        
    }
}

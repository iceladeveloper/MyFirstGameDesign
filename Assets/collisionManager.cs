using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionManager : MonoBehaviour{
   void OnTriggerEnter2D(Collider2D coll)
    { 
        Debug.Log("touched something");
        
    }

}

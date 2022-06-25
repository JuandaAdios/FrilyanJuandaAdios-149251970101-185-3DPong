using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
     public Vector3 initialImpulse;

   
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(initialImpulse, ForceMode.Impulse) ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

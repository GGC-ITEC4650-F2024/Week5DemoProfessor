using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigBodMover : MonoBehaviour
{
    Rigidbody myBod;
    // Start is called before the first frame update
    void Start()
    {
        myBod = GetComponent<Rigidbody>();
        myBod.velocity = 10 * Vector3.forward;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

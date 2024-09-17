using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharConMover : MonoBehaviour
{
    CharacterController myCon;

    private float ySpeed;
    // Start is called before the first frame update
    void Start()
    {
        myCon = GetComponent<CharacterController>();   
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 step = 10 * Vector3.forward;

        //falling
        if(myCon.isGrounded) {
            if(Input.GetButtonDown("Jump")) {
                ySpeed = 5;
            }
            else {
                ySpeed = -1;
            }
        } 
        else {
            ySpeed += (-9.81f * Time.deltaTime);
        }
        step.y = ySpeed;

        myCon.Move(step * Time.deltaTime);
    }
}

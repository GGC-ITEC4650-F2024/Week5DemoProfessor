using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FP_Mover : MonoBehaviour
{
    Transform myTran;

    public float speed;
    public float rotSpeed;

    private Vector3 myRot;

    // Start is called before the first frame update
    void Start()
    {
        myTran = GetComponent<Transform>();
        myRot = myTran.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        //MOVE
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 step = h * myTran.right + v * myTran.forward;
        step.y = 0; // don't fly
        myTran.position += (step * speed * Time.deltaTime);

        //ROTATE
        float mx = Input.GetAxis("Mouse X");
        float my = Input.GetAxis("Mouse Y");
        Vector3 rotStep = mx * Vector3.up + my * Vector3.right;
        myRot += (rotStep * rotSpeed * Time.deltaTime);
        if(myRot.x > 30) {myRot.x = 30;}
        if(myRot.x < -30) {myRot.x = -30;}
        myTran.eulerAngles = myRot;

    }
}

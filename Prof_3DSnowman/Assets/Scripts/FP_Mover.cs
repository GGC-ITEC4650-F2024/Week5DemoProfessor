using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FP_Mover : MonoBehaviour
{
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //move
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 step = h * transform.right + v * transform.forward;
        transform.position += (step * speed * Time.deltaTime);
    }
}

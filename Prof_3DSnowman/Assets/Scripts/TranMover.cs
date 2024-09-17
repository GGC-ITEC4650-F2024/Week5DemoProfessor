using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class TranMover : MonoBehaviour
{
    Transform myTran;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        myTran = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 step = speed * Vector3.forward;
        myTran.position += step * Time.deltaTime;
    }
}

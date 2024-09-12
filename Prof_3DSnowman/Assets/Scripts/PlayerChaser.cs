using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChaser : MonoBehaviour
{
    Transform myTran;

    Transform playerTran;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        myTran = GetComponent<Transform>();

        playerTran = GameObject.Find("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //MOVE
        Vector3 step = (playerTran.position - myTran.position).normalized;
        myTran.position += (step * speed * Time.deltaTime);

        //ROTATE
        myTran.forward = step;
    }
}

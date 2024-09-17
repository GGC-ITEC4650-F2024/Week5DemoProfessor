using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerChaser : MonoBehaviour
{
    Transform myTran;
    NavMeshAgent myAgent;

    Transform playerTran;

    //public float speed;

    // Start is called before the first frame update
    void Start()
    {
        myTran = GetComponent<Transform>();
        myAgent = GetComponent<NavMeshAgent>();
        playerTran = GameObject.Find("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        myAgent.SetDestination(playerTran.position);
        //MOVE
        //Vector3 step = (playerTran.position - myTran.position).normalized;
        //myTran.position += (step * speed * Time.deltaTime);

        //ROTATE
        ///myTran.forward = step;
    }
}

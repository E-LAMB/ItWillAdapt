using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{

    public GameObject target;
    public Transform ground_checker;

    public LayerMask boost_surface;

    public float speed;

    public NavMeshAgent my_agent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.CheckSphere(ground_checker.position, 3f, boost_surface))
        {
            speed = 6f;
        } else
        {
            speed = 3f;
        }

        my_agent.speed = speed;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            my_agent.SetDestination(target.transform.position);
        }
    }
}

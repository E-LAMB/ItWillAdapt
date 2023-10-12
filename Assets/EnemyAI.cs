using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{

    public GameObject target;

    public float speed;

    public NavMeshAgent my_agent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y < -5f)
        {
            speed = 8f;
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    NavMeshAgent nav;
    [SerializeField] GameObject target;

    private void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        target = GameObject.Find("Player");
    }

    private void Update()
    {
        if(nav.destination != target.transform.position)
        {
            nav.SetDestination(target.transform.position);
        }
        else
        {
            nav.SetDestination(transform.position);
        }
    }
}

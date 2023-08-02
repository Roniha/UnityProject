using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class anime : MonoBehaviour
{
    [SerializeField]
    [Tooltip("巡回する地点の配列")]
    private Transform[] Waypoints;

    private NavMeshAgent navMeshAgent;
    private Animator anim;
    private int currentWaypointIndex;

    private void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();

        // 最初のWaypointに向かって移動
        currentWaypointIndex = 0;
        navMeshAgent.SetDestination(Waypoints[currentWaypointIndex].position);
    }

    private void Update()
    {
        if (navMeshAgent.remainingDistance <= navMeshAgent.stoppingDistance)
        {
            // 次のWaypointのインデックスに切り替える
            currentWaypointIndex = (currentWaypointIndex + 1) % Waypoints.Length;
            navMeshAgent.SetDestination(Waypoints[currentWaypointIndex].position);
        }

        // 設定した条件に応じてアニメーションを制御
        anim.SetFloat("Speed", navMeshAgent.velocity.magnitude);
    }
}

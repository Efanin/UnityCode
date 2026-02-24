using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private NavMeshAgent agent;

    private void Update()
    {

            agent.SetDestination(player.transform.position);

    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class TesteNavMesh : MonoBehaviour
{
    public GameObject player;
    private NavMeshAgent nav;
    // Start is called before the first frame update
    void Awake()
    {
        nav = GetComponent<NavMeshAgent>();
        nav.SetDestination(player.transform.position);
    }
}

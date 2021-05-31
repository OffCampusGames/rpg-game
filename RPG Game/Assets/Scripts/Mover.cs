using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{

    //Config
    [SerializeField] Transform target;

    //Cache
    NavMeshAgent myNavMesh;

    // Start is called before the first frame update
    void Start()
    {
        myNavMesh = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        myNavMesh.destination = target.position;
    }
}

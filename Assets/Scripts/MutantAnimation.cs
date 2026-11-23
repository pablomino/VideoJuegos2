using UnityEngine;
using UnityEngine.AI;

public class MutantAnimation : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Animator animator;
    NavMeshAgent agent;
    bool running;

    [SerializeField]
    GameObject[] waypoints;
    private int currentWaypoint = 0;

    void Start()
    {
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        agent.destination = waypoints[currentWaypoint].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (agent.velocity.magnitude!=0f){
            animator.SetBool("walking",true);
        } else{
            animator.SetBool("walking",false);
        }

        if (waypoints.Length == 0)
            return;

        if (agent.pathPending)
            return;

        if (agent.remainingDistance <= agent.stoppingDistance)
        {
            NextWaypoint();
        }
    }

    void NextWaypoint()
    {
        currentWaypoint =
            (currentWaypoint + 1) % waypoints.Length;

        agent.SetDestination(
            waypoints[currentWaypoint].transform.position
        );
    }
}

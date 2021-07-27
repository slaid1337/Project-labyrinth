using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class enemyController : MonoBehaviour
{
    public NavMeshAgent agent;

    public Transform player;

    public LayerMask whatIsGround, whatIsPlayer;

    public int health;

    public float kickForce;

    //Patroling
    public Vector3 walkPoint;
    bool walkPointSet;
    public float walkPointRange;

    //Attacking
    public float timeBetweenAttacks;
    bool alreadyAttacked = false;
    public GameObject speare;

    //States
    public float sightRange, attackRange;
    public bool playerInSightRange, playerInAttackRange;

    private float attakTimer;
    private bool resetAttakSpeare;

    public bool kick;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        agent = gameObject.GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        //Check for sight and attack range
        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);
        playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, whatIsPlayer);

        if (!playerInSightRange && !playerInAttackRange) Patroling();
        if (playerInSightRange && !playerInAttackRange) ChasePlayer();
        if (playerInAttackRange && playerInSightRange) AttackPlayer();

        if (kick)
        {
            transform.position += -transform.forward * kickForce * Time.deltaTime;
        }

    }

    private void Patroling()
    {
        if (!walkPointSet) SearchWalkPoint();

        if (walkPointSet)
            agent.SetDestination(walkPoint);

        Vector3 distanceToWalkPoint = transform.position - walkPoint;

        //Walkpoint reached
        if (distanceToWalkPoint.magnitude < 1f)
            walkPointSet = false;
    }
    private void SearchWalkPoint()
    {
        //Calculate random point in range
        float randomZ = Random.Range(-walkPointRange, walkPointRange);
        float randomX = Random.Range(-walkPointRange, walkPointRange);

        walkPoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);

        if (Physics.Raycast(walkPoint, -transform.up, 2f, whatIsGround))
            walkPointSet = true;
    }

    private void ChasePlayer()
    {
        agent.SetDestination(player.position);
        alreadyAttacked = false;
        resetAttakSpeare = false;
        if (IsInvoking("resetAttak"))
        {
            CancelInvoke("resetAttak");
        }

    }

    private void AttackPlayer()
    {
        agent.SetDestination(transform.position);
        transform.LookAt(player);

        RaycastHit hit;
        if (Physics.Raycast(transform.position, gameObject.transform.forward, out hit))
        {

            if (!resetAttakSpeare)
            {
                Invoke("resetAttak", timeBetweenAttacks);
                resetAttakSpeare = true;
            }

            if (alreadyAttacked && (hit.collider.gameObject.tag == "Player" || hit.collider.gameObject.tag == "speare" || hit.collider.gameObject.tag == "playerShield"))
            {
                Instantiate(speare, transform.position, Quaternion.identity).GetComponent<speareDelete>().player = player;
                alreadyAttacked = false;
            }
            else if (hit.collider.gameObject.tag != "Player" && hit.collider.gameObject.tag != "speare" && hit.collider.gameObject.tag != "playerShield")
            {
                ChasePlayer();
            }
        }

    }

    private void resetAttak()
    {
        alreadyAttacked = true;
        resetAttakSpeare = false;
    }





    public void TakeDamage(int damage)
    {
        health -= damage;

        kick = true;
        Invoke("kickOff", 0.1f);      
        if (health <= 0) Invoke(nameof(DestroyEnemy), 0.5f);
    }

    private void kickOff()
    {
        kick = false;
    }

    private void DestroyEnemy()
    {
        Destroy(gameObject);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, sightRange);
    }




}

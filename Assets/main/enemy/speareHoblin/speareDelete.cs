using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speareDelete : MonoBehaviour
{
    public float deleteTime;
    public Transform player;
    private Rigidbody rb;
    public float speareSpeed;


    private void Start()
    {
        StartCoroutine(deleteSpeare(deleteTime));
        transform.LookAt(player);
        rb = gameObject.GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speareSpeed;
    }

    IEnumerator deleteSpeare(float deleteTime)
    {
        yield return new WaitForSeconds(deleteTime);
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<Move>().attak = true;
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{

    private float deleteTime = 2f;
    public float speareSpeed = 10f;
    private Rigidbody rb;
    public int damage;

    private void Start()
    {

        StartCoroutine(DeleteArrow(deleteTime));
        rb = gameObject.GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speareSpeed;
    }

    IEnumerator DeleteArrow(float deleteTime)
    {
        yield return new WaitForSeconds(deleteTime);
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            other.GetComponent<enemyController>().TakeDamage(damage);
            Destroy(gameObject);
        }

        else if (other.gameObject.tag == "swordGoblin")
        {
            other.GetComponent<swordGoblinController>().TakeDamage(damage);
            Destroy(gameObject);
        }

    }
}

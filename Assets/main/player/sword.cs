using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword : MonoBehaviour
{
    public int damage;
    public float hitTime;
    public bool attaked;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            var a = other.gameObject.GetComponent<enemyController>();
            a.TakeDamage(damage);
        }
        Debug.Log("HIT");
    }


    public void disableCollider()
    {
        gameObject.GetComponent<BoxCollider>().enabled = false;
    }


    private void Update()
    {
        if (attaked)
        {
            Debug.Log("lose");
            Invoke("disableCollider", hitTime);
            attaked = false;
        }
    }

}

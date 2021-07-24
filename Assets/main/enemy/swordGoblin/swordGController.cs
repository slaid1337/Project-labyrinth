using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swordGController : MonoBehaviour
{
    public bool attak;
    public float hitReset;
    public int damage;

    private void Awake()
    {
        damage = gameObject.transform.parent.GetComponent<swordGoblinController>().damage;
    }


    private void Update()
    {
        if (attak)
        {
            gameObject.GetComponent<BoxCollider>().enabled = true;
            Invoke("resetAttak", hitReset);
            attak = false;
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.transform.tag == "Player")
        {
            other.gameObject.GetComponent<Move>().attak = true;
            other.gameObject.GetComponent<Move>().damage = 1;
            other.gameObject.GetComponent<Move>().kickDirection = gameObject.transform.forward;
        }
    }

    private void resetAttak()
    {
        gameObject.GetComponent<BoxCollider>().enabled = false;
    }

}

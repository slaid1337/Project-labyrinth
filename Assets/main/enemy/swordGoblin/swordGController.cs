using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swordGController : MonoBehaviour
{
    public bool attak;
    public float hitReset;
    public int damage;
    public bool canAttak;
    public GameObject player;
    public bool playerInTrigger;



    private void Awake()
    {
        canAttak = true;
        damage = gameObject.transform.parent.GetComponent<swordGoblinController>().damage;
        player = GameObject.FindGameObjectWithTag("Player");
    }


    private void Update()
    {
         if (attak)
        {
            gameObject.GetComponent<BoxCollider>().enabled = true;
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        

        if (other.gameObject.transform.tag == "Player")
        { 
            if(player.GetComponent<Move>().shieldActive)
            {
                Invoke("attakWithShield",1f);         
            }

            else if (!player.GetComponent<Move>().shieldActive)
            {
                Invoke("soloAttak", 1f);
            }
        }
        
    }




    private void resetAttak()
    {
        canAttak = true;
    }

    private void attakWithShield()
    {
        player.GetComponent<Move>().kick = true;
        attak = false;
        gameObject.GetComponent<BoxCollider>().enabled = false;
    }

    private void soloAttak()
    {
        attakPlayer(player);
        attak = false;
        gameObject.GetComponent<BoxCollider>().enabled = false;
    }

    private void attakPlayer(GameObject other)
    {
        other.gameObject.GetComponent<Move>().attak = true;
        other.gameObject.GetComponent<Move>().damage = 1;
        other.gameObject.GetComponent<Move>().kickDirection = gameObject.transform.forward;
    }

}

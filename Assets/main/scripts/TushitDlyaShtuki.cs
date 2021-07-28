using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TushitDlyaShtuki : MonoBehaviour
{
    
    public GameObject gameObjectToDeactivateDlyaVody;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == GameObject.Find("Voda"))
        {

            gameObjectToDeactivateDlyaVody.SetActive(false);

        }

    }
}

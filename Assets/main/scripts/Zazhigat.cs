using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zazhigat : MonoBehaviour
{
    public GameObject gameObjectToDeactivateDlyaVody;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == GameObject.Find("Ogon"))
        {

            gameObjectToDeactivateDlyaVody.SetActive(true);

        }

    }
}

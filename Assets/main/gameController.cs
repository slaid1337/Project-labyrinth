using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController : MonoBehaviour
{
    public GameObject[] fillContainers;
    public GameObject[] emptyContainers;

    public int maxCurrentHearts;
    public int currentHearts;
    public int maxHearts;

    private void Start()
    {
        /*spawn hearts in UI*/
        for (int i = 0; i < maxCurrentHearts; i++)
        {
            if (i < currentHearts)
            {
                fillContainers[i].SetActive(true);
            } 
            
            if (i < maxCurrentHearts / 2)
            {
                emptyContainers[i].SetActive(true);
            }
        }
        /*spawn hearts in UI*/






    }

}

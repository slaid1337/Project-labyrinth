using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagiaOgna : MonoBehaviour
{
    public GameObject gameObjectToDeactivate;
    public bool flag;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            flag = !flag;
            if (flag == true)
            {
                gameObjectToDeactivate.SetActive(true);
                GameObject.Find("Player").gameObject.transform.GetComponent<MagiaVody>().flag1 = false;
                GameObject.Find("Voda").SetActive(false);

            }
            if (flag == false)
            {
                gameObjectToDeactivate.SetActive(false);
            }
        }


    }
}

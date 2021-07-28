using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagiaVody : MonoBehaviour
{
    public GameObject gameObjectToDeactivate;
    public bool flag1;

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            flag1 = !flag1;
            if (flag1 == true)
            {
                gameObjectToDeactivate.SetActive(true);
                GameObject.Find("Player").gameObject.transform.GetComponent<MagiaOgna>().flag = false;
                GameObject.Find("Ogon").SetActive(false);
            }
            if (flag1 == false)
            {
                gameObjectToDeactivate.SetActive(false);
            }
        }
        

    }
}

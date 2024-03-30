using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoreInfo : MonoBehaviour
{

    public GameObject MoreInfoPage;

    public void Trigger()
    {
        if (MoreInfoPage.activeInHierarchy == false)
        {
            MoreInfoPage.SetActive(true);
        }
    }


    public void Trigger2()
    {
        if (MoreInfoPage.activeInHierarchy == true)
        {
            MoreInfoPage.SetActive(false);
        }
        else
        {
            MoreInfoPage.SetActive(true);
        }
    }

}

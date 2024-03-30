using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoAboutGame : MonoBehaviour
{
    public GameObject AboutGame;
    public GameObject MoreInfoPage;

    public void Trigger()
    {
        if (AboutGame.activeInHierarchy == false)
        {
            AboutGame.SetActive(true);
           // MoreInfoPage.SetActive(false);
        }
    }


    public void Trigger2()
    {
        if (AboutGame.activeInHierarchy == true)
        {
            AboutGame.SetActive(false);
        }
        else
        {
            AboutGame.SetActive(true);
        }
    }


    public void Trigger3()
    {
        if (AboutGame.activeInHierarchy == true && MoreInfoPage.activeInHierarchy == true)
        {
            AboutGame.SetActive(false);
            MoreInfoPage.SetActive(false);
            
        }
    }
}

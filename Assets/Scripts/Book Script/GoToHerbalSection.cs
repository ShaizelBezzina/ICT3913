using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToHerbalSection : MonoBehaviour
{
    public GameObject HerbalCanvas;

    public void Trigger()
    {
        if (HerbalCanvas.activeInHierarchy == false)
        {
            HerbalCanvas.SetActive(true);
        }
        else
        {
            HerbalCanvas.SetActive(false);
        }
    }
}
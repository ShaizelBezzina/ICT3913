using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToCosmoSection : MonoBehaviour
{
    public GameObject CosmoCanvas;

    public void Trigger()
    {
        if (CosmoCanvas.activeInHierarchy == false)
        {
            CosmoCanvas.SetActive(true);
        }
        else
        {
            CosmoCanvas.SetActive(false);
        }
    }
}

    
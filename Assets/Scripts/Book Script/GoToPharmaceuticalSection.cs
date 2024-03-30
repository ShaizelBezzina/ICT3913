using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToPharmaceuticalSection : MonoBehaviour
{
    public GameObject PharmaceuticalCanvas;

    public void Trigger()
    {
        if (PharmaceuticalCanvas.activeInHierarchy == false)
        {
            PharmaceuticalCanvas.SetActive(true);
        }
        else
        {
            PharmaceuticalCanvas.SetActive(false);
        }
    }
}
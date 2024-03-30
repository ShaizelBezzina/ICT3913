using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToBiologicalCanvas : MonoBehaviour
{
    public GameObject BiologicalCanvas;

    public void Trigger()
    {
        if (BiologicalCanvas.activeInHierarchy == false)
        {
            BiologicalCanvas.SetActive(true);
        }
        else
        {
            BiologicalCanvas.SetActive(false);
        }
    }
}
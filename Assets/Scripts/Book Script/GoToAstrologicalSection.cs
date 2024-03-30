using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToAstrologicalSection : MonoBehaviour
{
    public GameObject AstrologicalCanvas;

    public void Trigger()
    {
        if (AstrologicalCanvas.activeInHierarchy == false)
        {
            AstrologicalCanvas.SetActive(true);
        }
        else
        {
            AstrologicalCanvas.SetActive(false);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapScript : MonoBehaviour
{
    public GameObject MapOfVoynich;

    public void Trigger()
    {
        if (MapOfVoynich.activeInHierarchy == false)
        {
            MapOfVoynich.SetActive(true);
        }
        else
        {
            MapOfVoynich.SetActive(false);
        }
    }
}

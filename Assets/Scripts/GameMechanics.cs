using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMechanics : MonoBehaviour
{

    public GameObject GameMechanicsUI;

    public void Trigger()
    {
        if (GameMechanicsUI.activeInHierarchy == false)
        {
            GameMechanicsUI.SetActive(true);
        }
    }

    public void Trigger2()
    {
        if (GameMechanicsUI.activeInHierarchy == true)
        {
            GameMechanicsUI.SetActive(false);
        }
        else
        {
            GameMechanicsUI.SetActive(true);
        }
    }
}

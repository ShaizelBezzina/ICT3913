using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoScript : MonoBehaviour
{
    public GameObject ForDemo;
    public GameObject Signs;


    public void Trigger()
    {
        if (ForDemo.activeInHierarchy == false)
        {
            ForDemo.SetActive(true);
            Signs.SetActive(false);
        }
        else
        {
            ForDemo.SetActive(false);
            Signs.SetActive(true);
        }
    }
}

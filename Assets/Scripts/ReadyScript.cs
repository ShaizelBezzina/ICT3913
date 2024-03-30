using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadyScript : MonoBehaviour
{
    public int pointsToWin;
    public int currentPoints;
    public GameObject signs;

    // Start is called before the first frame update
    void Start()
    {
        pointsToWin = signs.transform.childCount;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentPoints >= pointsToWin)
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
    }

    // Add this method to increment currentPoints
    public void AddPoints()
    {
        currentPoints++;
    }
}

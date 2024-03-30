using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageCompleted : MonoBehaviour
{

    public GameObject stageCompleted;
    // Start is called before the first frame update
    void Start()
    {
        stageCompleted.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D)) //Checking if the I key is pressed 
        {
            stageCompleted.SetActive(!stageCompleted.activeSelf); //Toogle canvas activiation
        }
    }
}

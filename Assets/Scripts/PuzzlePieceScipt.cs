using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzlePieceScipt : MonoBehaviour
{
    private Vector3 RightPosition;
    public bool InRightPosition;
    public bool Selected;


    // Start is called before the first frame update
    void Start()
    {
        RightPosition = transform.position;
        transform.position = new Vector3(Random.Range(0.6f, 5.33f), Random.Range(2.2f, -1.92f));
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, RightPosition) < 0.5f)
        {
            if (!Selected && !InRightPosition) // Check if the piece is not already in the right position
            {
                transform.position = RightPosition;
                InRightPosition = true;
            }
        }
    }
}
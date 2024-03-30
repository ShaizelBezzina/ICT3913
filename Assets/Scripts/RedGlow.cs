using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedGlow : MonoBehaviour
{
    // Reference to the shovel GameObject
    public GameObject Wrong;
    public GameObject redGlow;

    // Variable to track if the object has appeared
    private bool hasAppeared = false;

    // Called when a Collider2D enters this object's collider
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the colliding object is the shovel and the object has not appeared yet
        if (collision.gameObject == Wrong && !hasAppeared)
        {
            // Make the object appear (enable its renderer)
            redGlow.SetActive(true);

            // Set the flag to true to avoid repeated appearances
            hasAppeared = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemCollector : MonoBehaviour
{
    public GameObject redGlow;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Correct"))
        {
            redGlow.SetActive(true);
            StartCoroutine(DeactivateRedGlowAfterDelay(0.5f));
        }
    }

    IEnumerator DeactivateRedGlowAfterDelay(float delay)
    {
        // Wait for the specified delay
        yield return new WaitForSeconds(delay);

        // Deactivate the redGlow GameObject
        redGlow.SetActive(false);
    }
}

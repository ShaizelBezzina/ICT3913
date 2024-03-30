using UnityEngine;
using System.Collections;

public class Glow : MonoBehaviour
{
    public GameObject correctForm1;
    public GameObject correctForm2;
    public GameObject correctForm3;
    public bool moving;
    private bool finish;

    private float startPositionX;
    private float startPositionY;

    public GameObject GreenLight;
    public GameObject RedLight;

    private Vector3 resetPosition;

    void Start()
    {
        resetPosition = transform.localPosition;
    }

    void Update()
    {
        if (!finish && moving)
        {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

            transform.localPosition = new Vector3(
                mousePosition.x - startPositionX,
                mousePosition.y - startPositionY,
                transform.localPosition.z
            );
        }
    }

    private void OnMouseDown()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        startPositionX = mousePosition.x - transform.localPosition.x;
        startPositionY = mousePosition.y - transform.localPosition.y;

        moving = true;
    }

    private void OnMouseUp()
    {
        moving = false;

        if ((Mathf.Abs(transform.localPosition.x - correctForm1.transform.localPosition.x) <= 0.5f ||
             Mathf.Abs(transform.localPosition.x - correctForm2.transform.localPosition.x) <= 0.5f ||
             Mathf.Abs(transform.localPosition.x - correctForm3.transform.localPosition.x) <= 0.5f) &&
            (Mathf.Abs(transform.localPosition.y - correctForm1.transform.localPosition.y) <= 0.5f ||
             Mathf.Abs(transform.localPosition.y - correctForm2.transform.localPosition.y) <= 0.5f ||
             Mathf.Abs(transform.localPosition.y - correctForm3.transform.localPosition.y) <= 0.5f))
        {
            // Move the object to the correct form's position
            transform.position = new Vector3(
                Mathf.Abs(transform.localPosition.x - correctForm1.transform.localPosition.x) <= 0.5f ? correctForm1.transform.position.x :
                Mathf.Abs(transform.localPosition.x - correctForm2.transform.localPosition.x) <= 0.5f ? correctForm2.transform.position.x :
                correctForm3.transform.position.x,
                Mathf.Abs(transform.localPosition.y - correctForm1.transform.localPosition.y) <= 0.5f ? correctForm1.transform.position.y :
                Mathf.Abs(transform.localPosition.y - correctForm2.transform.localPosition.y) <= 0.5f ? correctForm2.transform.position.y :
                correctForm3.transform.position.y,
                Mathf.Abs(transform.localPosition.z - correctForm1.transform.localPosition.z) <= 0.5f ? correctForm1.transform.position.z :
                Mathf.Abs(transform.localPosition.z - correctForm2.transform.localPosition.z) <= 0.5f ? correctForm2.transform.position.z :
                correctForm3.transform.position.z
            );

            // Activate the GreenLight GameObject
            GreenLight.SetActive(true);

            // Start a coroutine to deactivate the GreenLight after 0.5 seconds
            StartCoroutine(DeactivateGreenLightAfterDelay(.5f));

            // Find the ReadyScript component and call AddPoints
            ReadyScript readyScript = GameObject.Find("PointsHandler").GetComponent<ReadyScript>();
            if (readyScript != null)
            {
                readyScript.AddPoints();
            }
        }
        else
        {
            // Reset the object's position
            transform.localPosition = resetPosition;

            // Deactivate the GreenLight GameObject
            GreenLight.SetActive(false);
        }
    }

    IEnumerator DeactivateGreenLightAfterDelay(float delay)
    {
        // Wait for the specified delay
        yield return new WaitForSeconds(delay);

        // Deactivate the GreenLight GameObject
        GreenLight.SetActive(false);
    }
}

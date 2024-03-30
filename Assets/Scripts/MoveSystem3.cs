using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSystem3 : MonoBehaviour
{

    public GameObject correctForm1;
    public GameObject correctForm2;
    public GameObject correctForm3;
    public bool moving;
    private bool finish;

    private float startPositionX;
    private float startPositionY;

    private Vector3 resetPosition;

    void Start()
    {
        resetPosition = this.transform.localPosition;
    }

    void Update()
    {
        if (!finish && moving)
        {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

            this.gameObject.transform.localPosition = new Vector3(
                mousePosition.x - startPositionX,
                mousePosition.y - startPositionY,
                this.gameObject.transform.localPosition.z
            );
        }
    }

    private void OnMouseDown()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        startPositionX = mousePosition.x - this.transform.localPosition.x;
        startPositionY = mousePosition.y - this.transform.localPosition.y;

        moving = true;
    }

    private void OnMouseUp()
    {
        moving = false;

        if ((Mathf.Abs(transform.localPosition.x - correctForm1.transform.localPosition.x) <= 0.5f ||
             Mathf.Abs(transform.localPosition.x - correctForm2.transform.localPosition.x) <= 0.5f ||
             Mathf.Abs(transform.localPosition.x - correctForm3.transform.localPosition.x) <= 0.5f) && //s
            (Mathf.Abs(transform.localPosition.y - correctForm1.transform.localPosition.y) <= 0.5f ||
            Mathf.Abs(transform.localPosition.y - correctForm2.transform.localPosition.y) <= 0.5f ||
            Mathf.Abs(transform.localPosition.y - correctForm3.transform.localPosition.y) <= 0.5f))
        {
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



        // Find the ReadyScript component and call AddPoints
        ReadyScript readyScript = GameObject.Find("PointsHandler").GetComponent<ReadyScript>();
            if (readyScript != null)
            {
                readyScript.AddPoints();
            }
        }
        else
        {
            this.transform.localPosition = new Vector3(resetPosition.x, resetPosition.y, resetPosition.z);
        }
    }
}
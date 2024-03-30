using UnityEngine;

public class MoveSystem : MonoBehaviour
{
    public GameObject correctForm;
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

        if (finish == false)
        {
            if (moving)
            {
                Vector3 mousePosition;
                mousePosition = Input.mousePosition;
                mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

                this.gameObject.transform.localPosition = new Vector3(mousePosition.x - startPositionX, mousePosition.y - startPositionY, this.gameObject.transform.localPosition.z);
            }
        }
    }

    private void OnMouseDown()
    {
        Vector3 mousePosition;
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);


        startPositionX = mousePosition.x - this.transform.localPosition.x;
        startPositionY = mousePosition.y - this.transform.localPosition.y;

        moving = true;
    }


    private void OnMouseUp()
    {
        moving = false;

        if (Mathf.Abs(this.transform.localPosition.x - correctForm.transform.localPosition.x) <= 0.5f &&
            Mathf.Abs(this.transform.localPosition.y - correctForm.transform.localPosition.y) <= 0.5f)
        {
            this.transform.position = new Vector3(correctForm.transform.position.x, correctForm.transform.position.y, correctForm.transform.position.z);
            finish = true;

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

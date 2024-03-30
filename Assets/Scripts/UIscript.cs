using UnityEngine;

public class UIscript : MonoBehaviour
{
    public GameObject UI; //Referncing the canvas named UI

    // Start is called before the first frame update
    void Start()
    {
        UI.SetActive(false); //Ensuring that the canvas is active so that only when I is pressed it appears
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I)) //Checking if the I key is pressed 
        {
            UI.SetActive(!UI.activeSelf); //Toogle canvas activiation
        }
    }
}
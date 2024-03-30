using UnityEngine;

public class MagnifyingGlassOnClick : MonoBehaviour
{
    public GameObject HintCanvas;

    public void Trigger()
    {
        if (HintCanvas.activeInHierarchy == false)
        {
            HintCanvas.SetActive(true);
        }
        else
        {
            HintCanvas.SetActive(false);
        }
    }
}
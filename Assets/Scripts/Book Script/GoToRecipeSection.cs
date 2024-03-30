using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToRecipeSection : MonoBehaviour
{
    public GameObject RecipeCanvas;

    public void Trigger()
    {
        if (RecipeCanvas.activeInHierarchy == false)
        {
            RecipeCanvas.SetActive(true);
        }
        else
        {
            RecipeCanvas.SetActive(false);
        }
    }
}
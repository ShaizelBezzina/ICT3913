using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitBookButton : MonoBehaviour
{

    public GameObject HerbalCanvas;
    public GameObject CosmoCanvas;
    public GameObject AstrologicalCanvas;
    public GameObject BiologicalCanvas;
    public GameObject PharmaceuticalCanvas;
    public GameObject RecipeCanvas;

    public void Trigger1()
    {
        if (HerbalCanvas.activeInHierarchy == true || HerbalCanvas.activeInHierarchy && CosmoCanvas.activeInHierarchy && AstrologicalCanvas.activeInHierarchy && BiologicalCanvas.activeInHierarchy && PharmaceuticalCanvas.activeInHierarchy && RecipeCanvas.activeInHierarchy == true)
        {
            HerbalCanvas.SetActive(false);
            CosmoCanvas.SetActive(false);
            AstrologicalCanvas.SetActive(false);
            BiologicalCanvas.SetActive(false);
            PharmaceuticalCanvas.SetActive(false);
            RecipeCanvas.SetActive(false);
        }
    }

    public void Trigger2()
    {
        if (HerbalCanvas.activeInHierarchy && CosmoCanvas.activeInHierarchy == true || HerbalCanvas.activeInHierarchy && CosmoCanvas.activeInHierarchy && AstrologicalCanvas.activeInHierarchy && BiologicalCanvas.activeInHierarchy && PharmaceuticalCanvas.activeInHierarchy && RecipeCanvas.activeInHierarchy == true 
            || CosmoCanvas.activeInHierarchy && AstrologicalCanvas.activeInHierarchy && BiologicalCanvas.activeInHierarchy && PharmaceuticalCanvas.activeInHierarchy && RecipeCanvas.activeInHierarchy == true || CosmoCanvas.activeInHierarchy == true)
        {
            HerbalCanvas.SetActive(false);
            CosmoCanvas.SetActive(false);
            AstrologicalCanvas.SetActive(false);
            BiologicalCanvas.SetActive(false);
            PharmaceuticalCanvas.SetActive(false);
            RecipeCanvas.SetActive(false);
        }
    }

    public void Trigger3()
    {
        if (HerbalCanvas.activeInHierarchy && CosmoCanvas.activeInHierarchy && AstrologicalCanvas.activeInHierarchy == true || HerbalCanvas.activeInHierarchy && CosmoCanvas.activeInHierarchy && AstrologicalCanvas.activeInHierarchy && BiologicalCanvas.activeInHierarchy && PharmaceuticalCanvas.activeInHierarchy && RecipeCanvas.activeInHierarchy == true
            || HerbalCanvas.activeInHierarchy && AstrologicalCanvas.activeInHierarchy && BiologicalCanvas.activeInHierarchy && PharmaceuticalCanvas.activeInHierarchy && RecipeCanvas.activeInHierarchy == true)
        {
            HerbalCanvas.SetActive(false);
            CosmoCanvas.SetActive(false);
            AstrologicalCanvas.SetActive(false);
            BiologicalCanvas.SetActive(false);
            PharmaceuticalCanvas.SetActive(false);
            RecipeCanvas.SetActive(false);
        }
    }

    public void Trigger4()
    {
        if (HerbalCanvas.activeInHierarchy && CosmoCanvas.activeInHierarchy && AstrologicalCanvas.activeInHierarchy && BiologicalCanvas.activeInHierarchy == true || HerbalCanvas.activeInHierarchy && CosmoCanvas.activeInHierarchy && AstrologicalCanvas.activeInHierarchy && BiologicalCanvas.activeInHierarchy && PharmaceuticalCanvas.activeInHierarchy && RecipeCanvas.activeInHierarchy == true
            || HerbalCanvas.activeInHierarchy && CosmoCanvas.activeInHierarchy && BiologicalCanvas.activeInHierarchy && PharmaceuticalCanvas.activeInHierarchy && RecipeCanvas.activeInHierarchy == true)
        {
            HerbalCanvas.SetActive(false);
            CosmoCanvas.SetActive(false);
            AstrologicalCanvas.SetActive(false);
            BiologicalCanvas.SetActive(false);
            PharmaceuticalCanvas.SetActive(false);
            RecipeCanvas.SetActive(false);
        }
    }

    public void Trigger5()
    {
        if (HerbalCanvas.activeInHierarchy && CosmoCanvas.activeInHierarchy && AstrologicalCanvas.activeInHierarchy && BiologicalCanvas.activeInHierarchy && PharmaceuticalCanvas.activeInHierarchy == true || HerbalCanvas.activeInHierarchy && CosmoCanvas.activeInHierarchy && AstrologicalCanvas.activeInHierarchy && BiologicalCanvas.activeInHierarchy && PharmaceuticalCanvas.activeInHierarchy && RecipeCanvas.activeInHierarchy == true
            || HerbalCanvas.activeInHierarchy && CosmoCanvas.activeInHierarchy && AstrologicalCanvas.activeInHierarchy && PharmaceuticalCanvas.activeInHierarchy && RecipeCanvas.activeInHierarchy == true)
        {
            HerbalCanvas.SetActive(false);
            CosmoCanvas.SetActive(false);
            AstrologicalCanvas.SetActive(false);
            BiologicalCanvas.SetActive(false);
            PharmaceuticalCanvas.SetActive(false);
            RecipeCanvas.SetActive(false);
        }
    }

    public void Trigger6()
    {
        if (HerbalCanvas.activeInHierarchy && CosmoCanvas.activeInHierarchy && AstrologicalCanvas.activeInHierarchy && BiologicalCanvas.activeInHierarchy && PharmaceuticalCanvas.activeInHierarchy && RecipeCanvas.activeInHierarchy == true || HerbalCanvas.activeInHierarchy && CosmoCanvas.activeInHierarchy && AstrologicalCanvas.activeInHierarchy && BiologicalCanvas.activeInHierarchy && PharmaceuticalCanvas.activeInHierarchy && RecipeCanvas.activeInHierarchy == true 
            || HerbalCanvas.activeInHierarchy && CosmoCanvas.activeInHierarchy && AstrologicalCanvas.activeInHierarchy && BiologicalCanvas.activeInHierarchy && RecipeCanvas.activeInHierarchy == true)
        {
            HerbalCanvas.SetActive(false);
            CosmoCanvas.SetActive(false);
            AstrologicalCanvas.SetActive(false);
            BiologicalCanvas.SetActive(false);
            PharmaceuticalCanvas.SetActive(false);
            RecipeCanvas.SetActive(false);
        }
    }
}

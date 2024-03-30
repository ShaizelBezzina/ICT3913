using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class DragAndDrop : MonoBehaviour
{
    public GameObject selectedPiece;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            // Check if hit.transform is not null before accessing properties
            if (hit.transform != null && hit.transform.CompareTag("Puzzle"))
            {
                PuzzlePieceScipt piece = hit.transform.GetComponent<PuzzlePieceScipt>();

                // Check if the pieceScript component is not null before accessing its properties
                if (piece != null && !piece.InRightPosition)
                {
                    selectedPiece = hit.transform.gameObject;
                    piece.Selected = true;
                }
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (selectedPiece != null)
            {
                // Ensure selectedPiece is not null before accessing its component
                PuzzlePieceScipt piece = selectedPiece.GetComponent<PuzzlePieceScipt>();
                if (piece != null)
                {
                    piece.Selected = false;
                }
                selectedPiece = null;
            }
        }

        if (selectedPiece != null)
        {
            Vector3 MousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            selectedPiece.transform.position = new Vector3(MousePoint.x, MousePoint.y, 0);
        }
    }
}
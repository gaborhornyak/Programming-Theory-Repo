using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputControl : MonoBehaviour
{
    [SerializeField]
    private Camera _mainCamera;

    // Update is called once per frame
    void Update()
    {
        // on left click we check if object is selected
        if (Input.GetMouseButtonDown(0))
        {
            HandleSelection();
        }
    }

    // ABSTRACTION
    void HandleSelection()
    {
        var ray = _mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            BaseShape selectedShape = hit.collider.GetComponent<BaseShape>();
            // if we clicked on a shape then do a trick
            if(selectedShape != null)
            {
                selectedShape.DoTrick();
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputControl : MonoBehaviour
{
    [SerializeField]
    private Camera _mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // on left click we check if object is selected
        if (Input.GetMouseButtonDown(0))
        {
            HandleSelection();
        }
    }

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

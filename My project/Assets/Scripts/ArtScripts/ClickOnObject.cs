using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ClickOnObject : MonoBehaviour
{

    public GameObject currentObject;
    
    private void Start()
    {
        
    }

    private void Update()
    {
        if(Input.GetMouseButtonUp(0))
        {
            Ray theRay = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(theRay, out RaycastHit hited))
            {
                currentObject = hited.transform.gameObject;
               
            }
        }
    }
}
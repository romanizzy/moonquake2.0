using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinMoon : MonoBehaviour
{

    public GameObject theMoon;
    private float speed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
        if (Input.GetMouseButton(0))
        {
             float translation = Input.GetAxis("Mouse X");
             float rotation = Input.GetAxis("Mouse Y");

             translation *= -1;

             theMoon.transform.Rotate(new Vector3(rotation*speed,translation*speed, 0),Space.World);
            

        }
        
    }

    }


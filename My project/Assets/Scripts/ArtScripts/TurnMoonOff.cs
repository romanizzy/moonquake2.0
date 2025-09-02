using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnMoonOff : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {
        //turnitoff();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.childCount>0)
        {
            turnitoff();
        }
    }


    private void turnitoff()
    {
        for(int i = 0; i < gameObject.transform.childCount; i++)
        {
                   
            gameObject.transform.GetChild(i).gameObject.SetActive(false);
        }

        gameObject.transform.GetChild(0).gameObject.SetActive(true);

        enabled = false;
    }
}

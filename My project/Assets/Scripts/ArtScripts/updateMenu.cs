using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class updateMenu : MonoBehaviour
{


    public GameObject theMoon;
    private GameObject Apollo;
    private int thePreivous;
    public TurnMoonOff myMoonParents;

    // Start is called before the first frame update
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HandleInputData(int val)
    {
        theMoon.transform.GetChild(thePreivous).gameObject.SetActive(false);
        theMoon.transform.GetChild(val).gameObject.SetActive(true);
        thePreivous = val;
        

    }

    public void OnToggle(bool state)
    {

        GameObject[] activeAndInactive = FindObjectsByType<GameObject>(FindObjectsInactive.Include, FindObjectsSortMode.None);
        for (int i = 0; i < activeAndInactive.Length; i++)
        {
            if (activeAndInactive[i].gameObject.name == "Apollo")
            {
                Apollo = activeAndInactive[i];
            }
        }

        Apollo.SetActive(state);
    }
}

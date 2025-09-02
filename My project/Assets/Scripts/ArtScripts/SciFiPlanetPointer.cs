using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SciFiPlanetPointer : MonoBehaviour
{

    public ClickOnObject newObject; 

    private GameObject myOwnPointer;

    public GameObject menu;
    private RectTransform menuTrans;
    
    

    private Vector3 firstLine = new Vector3(-125,100,-300);
    private LineRenderer myLine;
    public GameObject middle; 
    public GameObject thePlace;

    private Vector3 negativeVec;

    public GameObject UIleft;
    public GameObject UIright;


    

    private Vector3 sideVec3;
    private Vector3 negativesideVec3;




    // Start is called before the first frame update
    void Start()
    {

        menu = GameObject.FindGameObjectWithTag("Menu");
        menuTrans = menu.GetComponent<RectTransform>();
        

            newObject = GameObject.FindGameObjectWithTag("Manager").gameObject.GetComponent<ClickOnObject>();
            middle = GameObject.FindGameObjectWithTag("Middle").gameObject;
            thePlace = gameObject; //this game obehct


        UIright = GameObject.FindGameObjectWithTag("right");
        UIleft = GameObject.FindGameObjectWithTag("left");

        

        myLine = gameObject.GetComponent<LineRenderer>();
        myLine.widthMultiplier = 1.7f;
        myLine.positionCount = 3;

        negativeVec = new Vector3(125, 100, -300);


        sideVec3 = new Vector3(-400, 100, -300);
        negativesideVec3 = new Vector3(400, 100, -300);
    }

    // Update is called once per frame
    void Update()
    {



        //myOwnPointer = newObject.currentObject;
        if (myOwnPointer != null)
        {
            if (myOwnPointer.transform.position.x > middle.transform.position.x)
            {

                myLine.SetPosition(0, myOwnPointer.transform.position);
                myLine.SetPosition(1, negativeVec);
                myLine.SetPosition(2, negativesideVec3);

                UIleft.SetActive(false);
                UIright.SetActive(true);

                menuTrans.offsetMin = new Vector2(15,410);
                menuTrans.offsetMax = new Vector2(-1425, -30);


            }
            else
            {
                UIleft.SetActive(true);
                UIright.SetActive(false);

                

                menuTrans.offsetMin = new Vector2(1425, 410);
                menuTrans.offsetMax = new Vector2(-15, -30);



                myLine.SetPosition(0, myOwnPointer.transform.position);
                myLine.SetPosition(1, firstLine);
                myLine.SetPosition(2, sideVec3);

            }

            if (myOwnPointer.transform.position.z > middle.transform.position.x)
            {

                UIleft.SetActive(false);
                UIright.SetActive(false);
                myOwnPointer = null;

                menuTrans.offsetMax = new Vector2(-15, -30);
                menuTrans.offsetMin = new Vector2(1425, 410);
                



                myLine.SetPosition(0, middle.transform.position);
                myLine.SetPosition(1, middle.transform.position);
                myLine.SetPosition(2, middle.transform.position);

            }
            else
            {


            }
        }
        else//when null
        {
          
            menuTrans.offsetMax = new Vector2(-15, -30);
            menuTrans.offsetMin = new Vector2(1425, 410);
            


            UIleft.SetActive(false);
            UIright.SetActive(false);
        }
        if(myOwnPointer != null)
        {
            if(myOwnPointer.active == false)
            {
                myLine.SetPosition(0, middle.transform.position);
                myLine.SetPosition(1, middle.transform.position);
                myLine.SetPosition(2, middle.transform.position);

            }
            
        }
        



        if (newObject.currentObject == null || newObject.currentObject.gameObject.tag == "Moon")
        {
            
        }
        else 
        {

            myOwnPointer = newObject.currentObject;
            
        }

        
            
        

             


    }
}

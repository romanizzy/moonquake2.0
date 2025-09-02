using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlotOnSurface : MonoBehaviour
{
    public GameObject theMoon;
    private SphereCollider moonCollider;
    private float radius;
    public GameObject theButton;
    private Vector3 myVector;

    //use awake

    
    void Start()
    {
        var render = theMoon.GetComponent<Renderer>();
        moonCollider = theMoon.GetComponent<SphereCollider>();
        radius = (render.bounds.extents.magnitude / 2);
        radius *= 1.1f;

       
     

        Instantiate(theButton, GPSLocation(.6f, 26f), Quaternion.identity, theMoon.transform);
        Instantiate(theButton, GPSLocation(-25f, 12f), Quaternion.identity, theMoon.transform);
        Instantiate(theButton, GPSLocation(15f, 1f), Quaternion.identity, theMoon.transform);
    }

    private Vector3 GPSLocation(float Lat, float Lon)
    {


        Vector3 result;
        float ltR = Lat * Mathf.Deg2Rad;
        float lnR = Lon * Mathf.Deg2Rad;

        float xPos = (radius * transform.lossyScale.z) * Mathf.Cos(ltR) * Mathf.Cos(lnR);
        float zPos = (radius * transform.lossyScale.z) * Mathf.Cos(ltR) * Mathf.Sin(lnR);
        float yPos = (radius * transform.lossyScale.z) * Mathf.Sin(ltR);

        

        Vector3 earthPositon = theMoon.transform.position;
        result = new Vector3(xPos + earthPositon.x, yPos + earthPositon.y, zPos + earthPositon.z);


        return result;
    }
        // Update is called once per frame
        void Update()
    {
       


    }
}

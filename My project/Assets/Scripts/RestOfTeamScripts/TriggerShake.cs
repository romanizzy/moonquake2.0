using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerShake : MonoBehaviour
{
    public CameraShake myShake;
    public updateInfor forMagnitude;

    private float duration = .15f;
    private float magnitude = 0;

    private float previousMag=0;

    private bool notWhile = false;

   // public GameObject seeMessage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        

        magnitude = forMagnitude.magnitudeForShake;
        Debug.Log(magnitude);



        if (Input.GetMouseButtonDown(0) && notWhile == false && previousMag != magnitude)
        {

          StartCoroutine(stack());
            previousMag = magnitude;
           // seeMessage.SetActive(false);
        }
        

    }

    IEnumerator stack()
    {
        notWhile = true;

        StartCoroutine(myShake.Shake(8f, magnitude / 500));
        yield return new WaitForSeconds(.01f);

        notWhile = false;

    }
}

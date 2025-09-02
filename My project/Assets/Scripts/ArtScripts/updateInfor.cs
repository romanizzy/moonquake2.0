using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

using UnityEngine.UI;


public class updateInfor : MonoBehaviour
{

    public CSVreader myReader;
    public ClickOnObject ClickedObject;
    private GameObject GOinfo;


    public GameObject clickOn;


    private AudioSource audioS;

    List<List<string>> theQuakeInfo;
    List<List<string>> theApolloInfo;


    //public GameObject seemessgae;

    public float magnitudeForShake;

    public TextMeshProUGUI[] date;
    public TextMeshProUGUI[] magnitude;
    public TextMeshProUGUI[] LongLat;
    public GameObject[] WavePanels;





    public GameObject myAudioManager;

    public GameObject AudioSourceObject;





    // Start is called before the first frame update
    void Start()
    {
        theQuakeInfo = myReader.ReadCSVFile("QuakeMapping");
        theApolloInfo = myReader.ReadCSVFile("StationMapping");

    }

    // Update is called once per frame
    void Update()
    {


        
        

        if (ClickedObject.currentObject == null || ClickedObject.currentObject.gameObject.tag == "Moon")
        {
            clickOn.SetActive(false);
        }
        else
        {
            GOinfo = ClickedObject.currentObject;

            if(GOinfo.transform.parent.name == "Apollo")
            {
                putInfoApollo();
            }

            else
            {
               putInfoEarthquakes();
            }
            
            
        }


        


    }


    void putInfoApollo()
    {
        date[0].text = ("Apollo: " + theApolloInfo[GOinfo.GetComponent<KeepIndex>().thisIndex][0].Trim());
        date[1].text = ("Apollo: " + theApolloInfo[GOinfo.GetComponent<KeepIndex>().thisIndex][0].Trim());

        LongLat[0].text = ("Latitude: " + theApolloInfo[GOinfo.GetComponent<KeepIndex>().thisIndex][1].Trim() + "°\nLongitude: " + theApolloInfo[GOinfo.GetComponent<KeepIndex>().thisIndex][2].Trim() + "°");
        LongLat[1].text = ("Latitude: " + theApolloInfo[GOinfo.GetComponent<KeepIndex>().thisIndex][1].Trim() + "°\nLongitude: " + theApolloInfo[GOinfo.GetComponent<KeepIndex>().thisIndex][2].Trim() + "°");

        WavePanels[0].SetActive(false);
        WavePanels[1].SetActive(false);

        magnitude[0].text = "";
        magnitude[1].text = "";
    }

    void putInfoEarthquakes()
    {


        WavePanels[0].SetActive(true);
        WavePanels[1].SetActive(true);

        date[0].text = (theQuakeInfo[GOinfo.GetComponent<KeepIndex>().thisIndex][0].Trim() + ", " + theQuakeInfo[GOinfo.GetComponent<KeepIndex>().thisIndex][1].Trim() + ", " + theQuakeInfo[GOinfo.GetComponent<KeepIndex>().thisIndex][2].Trim());
        date[1].text = (theQuakeInfo[GOinfo.GetComponent<KeepIndex>().thisIndex][0].Trim() + ", " + theQuakeInfo[GOinfo.GetComponent<KeepIndex>().thisIndex][1].Trim() + ", " + theQuakeInfo[GOinfo.GetComponent<KeepIndex>().thisIndex][2].Trim());

        magnitude[0].text = ("Magnitude " + theQuakeInfo[GOinfo.GetComponent<KeepIndex>().thisIndex][8].Trim() + " M_L");
        magnitude[1].text = ("Magnitude " + theQuakeInfo[GOinfo.GetComponent<KeepIndex>().thisIndex][8].Trim() + " M_L");


        LongLat[0].text = ("Latitude: " + theQuakeInfo[GOinfo.GetComponent<KeepIndex>().thisIndex][6].Trim() + "°\nLongitude: " + theQuakeInfo[GOinfo.GetComponent<KeepIndex>().thisIndex][7].Trim() + "°");
        LongLat[1].text = ("Latitude: " + theQuakeInfo[GOinfo.GetComponent<KeepIndex>().thisIndex][6].Trim() + "°\nLongitude: " + theQuakeInfo[GOinfo.GetComponent<KeepIndex>().thisIndex][7].Trim() + "°");




        WavePanels[0].GetComponent<Image>().color = new Color(255, 255, 255, 255);
        WavePanels[1].GetComponent<Image>().color = new Color(255, 255, 255, 255);

        WavePanels[0].GetComponent<Image>().sprite = Sprite.Create(myAudioManager.GetComponent<LoadImages>().imageList[GOinfo.GetComponent<KeepIndex>().thisIndex], new Rect(0, 0, myAudioManager.GetComponent<LoadImages>().imageList[GOinfo.GetComponent<KeepIndex>().thisIndex].width, myAudioManager.GetComponent<LoadImages>().imageList[GOinfo.GetComponent<KeepIndex>().thisIndex].height), Vector2.zero);
        WavePanels[1].GetComponent<Image>().sprite = Sprite.Create(myAudioManager.GetComponent<LoadImages>().imageList[GOinfo.GetComponent<KeepIndex>().thisIndex], new Rect(0, 0, myAudioManager.GetComponent<LoadImages>().imageList[GOinfo.GetComponent<KeepIndex>().thisIndex].width, myAudioManager.GetComponent<LoadImages>().imageList[GOinfo.GetComponent<KeepIndex>().thisIndex].height), Vector2.zero);


        audioS = AudioSourceObject.GetComponent<AudioSource>();
        audioS.clip = myAudioManager.GetComponent<LoadAudio>().audioClipList[GOinfo.GetComponent<KeepIndex>().thisIndex];

        magnitudeForShake = float.Parse(theQuakeInfo[GOinfo.GetComponent<KeepIndex>().thisIndex][8].Trim());


        //seemessgae.SetActive(true);
        clickOn.SetActive(true);

        audioS.Play();





    }




}

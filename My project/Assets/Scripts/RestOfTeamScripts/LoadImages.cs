using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadImages : MonoBehaviour 
{

    public List<Texture2D> imageList = new List<Texture2D>();
    // public string folderName = "png waveform images";

    // Start is called before the first frame update
    void Start()
    {
        // Image[] images = Resources.LoadAll<Image>(folderName);

        // if (images != null && images.Length > 0) {
        //     imageList.AddRange(images);
        // }
        // else {
        //     Debug.LogWarning("No images found in the folder: " + folderName);
        // }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

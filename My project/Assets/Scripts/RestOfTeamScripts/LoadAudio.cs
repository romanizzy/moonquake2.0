using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAudio : MonoBehaviour
{
    public List<AudioClip> audioClipList = new List<AudioClip>();
    // public string folderName = "Audio";

    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log("starting load audio");

        // AudioClip[] audioClips = Resources.LoadAll<AudioClip>(folderName);

        // if (audioClips != null && audioClips.Length > 0) {
        //     audioClipList.AddRange(audioClips);
        // }
        // else {
        //     Debug.LogWarning("No audio clips found in the folder: " + folderName);
        // }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

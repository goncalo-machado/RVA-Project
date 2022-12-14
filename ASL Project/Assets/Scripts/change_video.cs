using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using System.Linq;
using UnityEngine.SceneManagement;
using System;

public class change_video : MonoBehaviour
{

    private int videoIndex;
    private GameObject renderTexture;
    private VideoPlayer videoPlayer;
    public List<VideoClip> videoClips = new List<VideoClip>();

    void Start(){
        
        var loadedObjects = Resources.LoadAll(MenuController.category);
        foreach (var loadedObject in loadedObjects)
        {
           videoClips.Add(loadedObject as VideoClip);
        }

        videoIndex = 0;
        renderTexture = GameObject.Find("renderTexture");
        videoPlayer = renderTexture.gameObject.GetComponent<VideoPlayer>();
        videoPlayer.clip = videoClips[videoIndex];
    }

    public void changeVideo(){

        if (videoIndex == videoClips.Count-1){
            SceneManager.LoadScene("Main Menu Scene");
        }

        videoIndex += 1;
        videoPlayer.clip = videoClips[videoIndex];
    }

    public void changeVideo2(){
        
        if (videoIndex != 0){
            videoIndex -= 1;
            videoPlayer.clip = videoClips[videoIndex];
        }
    }
}

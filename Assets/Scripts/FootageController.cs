using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FootageController : MonoBehaviour {

    private VideoPlayer videoPlayerDeer;
    private VideoPlayer videoPlayerDeer2;

    public GameObject quad;
    public GameObject quad2;

    private bool quadPlaying = false;


    // Grab all videoplayer components on start

    private void Awake(){
        videoPlayerDeer = quad.GetComponent<VideoPlayer>();
        videoPlayerDeer2 = quad2.GetComponent<VideoPlayer>();
    }

    // Because there is a mixture of landscape and portrait scenes, I have added orientation instructions on each scene to stop any incorrect orientation which happens when switching between the two

    void Start () {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
	}
	
    // Will toggle between the two deer videos

    public void PlayButton(){
        if (quadPlaying == false)
        {
            Debug.Log("Hello Carl");
            videoPlayerDeer.Play();
            quadPlaying = true;
        }
        else{
            videoPlayerDeer.Stop();
            videoPlayerDeer2.Play();
            quadPlaying = false;
        }
    }

    public void HomeButton(){
        SceneManager.LoadScene("HomeScreen");
    }
}

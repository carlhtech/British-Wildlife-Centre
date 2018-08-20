using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Class used to test access to the phones camera


public class CameraScript : MonoBehaviour {


    static WebCamTexture backCam;
    public RawImage rawImage;


    // Will ask if the camera is playing already, if not... start a webcam texture

	void Start () {
        if(backCam == null){
            backCam = new WebCamTexture();
        }

        rawImage.texture = backCam;
        rawImage.material.mainTexture = backCam;
        //GetComponent<Renderer>().material.mainTexture = backCam;

        if(!backCam.isPlaying){
            backCam.Play();
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

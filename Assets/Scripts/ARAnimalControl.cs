using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


// Links the first button of the AR Animal scene to the ARKit scene


public class ARAnimalControl : MonoBehaviour {

    public Button arFoxButton;


	// Use this for initialization
	void Start () {
        Button arFoxBtn = arFoxButton.GetComponent<Button>();
        arFoxBtn.onClick.AddListener(ARFoxPress);
	}
	
    void ARFoxPress(){
        SceneManager.LoadScene("UnityARKitScene 1");
    }
}

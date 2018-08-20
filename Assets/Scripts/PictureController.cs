using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


// Script is also used to help with the 'picturebook' animating.
// It recognises if the deer picture is pressed on the fake camera roll and move onto next animation which is the tagging of 'deer'


public class PictureController : MonoBehaviour {


    public GameObject deerAdded;
    public int deerPressed = 0;


    // Set player prefs if deer is pressed and then can be used in next scene as 'IsPressed'

	void Start () {
        deerAdded.SetActive(false);
        deerPressed = PlayerPrefs.GetInt("deerTagPressed");

        if (deerPressed == 1)
        {
            deerAdded.SetActive(true);
            StartCoroutine(DeerPressedOff());
        }
        if (deerPressed == 0)
        {
            deerAdded.SetActive(false);
        }
	}
	

    public void CameraOpen(){
        SceneManager.LoadScene("PictureBookCamera");
    }

    IEnumerator DeerPressedOff(){
        yield return new WaitForSeconds(2.0f);
        deerPressed = 0;
        Destroy(deerAdded);
        PlayerPrefs.SetInt("deerTagPressed", 0);
    }

}

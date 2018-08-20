using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// This class is used to animate what WOULD happen in the picturebook scene.
// It has had to be animated due to difficulties getting the camera roll and camera to load from device during runtime


public class DeerAnimation : MonoBehaviour {

    private Animator anim;

    public GameObject deerImage;

    public GameObject tagPanel;



	// Use this for initialization
	void Start () {
        anim = deerImage.GetComponent<Animator>();
        tagPanel.SetActive(false);
	}
	
    public void PlayAnim(){
        anim.SetTrigger("DeerPressed");
        StartCoroutine(PanelDelay());
    }

    IEnumerator PanelDelay(){
        yield return new WaitForSeconds(0.5f);
        tagPanel.SetActive(true);
    }

    public void DeerTagPress(){
        PlayerPrefs.SetInt("deerTagPressed", 1);
        SceneManager.LoadScene("PictureBook");
    }

}

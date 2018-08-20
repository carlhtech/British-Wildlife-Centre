using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EncycController : MonoBehaviour {


    // Some button methods to control the UI canvas's on Encyclopedia page

    public GameObject canvas;
    public GameObject adderCanvas;



    public void AdderPress(){
        canvas.SetActive(false);
        adderCanvas.SetActive(true);
    }

    public void BackButton(){
        adderCanvas.SetActive(false);
        canvas.SetActive(true);
    }

    public void HomeButton(){
        SceneManager.LoadScene("HomeScreen");
    }
}

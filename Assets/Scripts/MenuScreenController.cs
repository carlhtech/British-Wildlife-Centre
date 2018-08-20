using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Loads the quiz scene from the quiz MENU ... not the main menu

public class MenuScreenController : MonoBehaviour {

    public void StartGame(){
        SceneManager.LoadScene("Quiz");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class DataController : MonoBehaviour {
    // NIU - rounddata was used to hold multiple rounds for the quiz

   // public RoundData[] allRoundData;


	void Start () {
        DontDestroyOnLoad(gameObject);

        SceneManager.LoadScene("QuizMenuScreen");
	}

    /*public RoundData GetCurrentRoundData(){
        return allRoundData[0];
    }*/
	
	
}

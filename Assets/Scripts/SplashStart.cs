using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// SplashStart will just run a coroutine to delay the loading of the main scene
// This will give time for the opening scene animation to play and then load scene


public class SplashStart : MonoBehaviour {

	void Start () {
        StartCoroutine(Delay());
	}
	
    IEnumerator Delay(){
        yield return new WaitForSeconds(3.5f);
        SceneManager.LoadScene("HomeScreen");
    }
	
}

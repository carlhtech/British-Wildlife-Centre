using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class HomeButton : MonoBehaviour {

    public Button goHome;

    // Home screen button pressing

	void Start () {
        Button homeBtn = goHome.GetComponent<Button>();
		homeBtn.onClick.AddListener(HomePress);
	}
	
    public void HomePress(){
        SceneManager.LoadScene("HomeScreen");
    }
}

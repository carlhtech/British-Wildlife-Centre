using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// Menu button solely for map scene. Didnt originally add the prefab so this was used

public class MenuButton : MonoBehaviour {

	public Button menuButton;


	// Use this for initialization
	void Start () {
		Button menuBtn = menuButton.GetComponent<Button> ();
		menuBtn.onClick.AddListener (MenuPress);

	}
	
	void MenuPress(){
		SceneManager.LoadScene ("MainMenu");
	}
}

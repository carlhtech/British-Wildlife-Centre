using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// Load menu from menu icon on each feature scene


public class MapMenuButton : MonoBehaviour
{

	public Button menuButton;


	// Use this for initialization
	void Start()
	{
		Button menuBtn = menuButton.GetComponent<Button>();
		menuBtn.onClick.AddListener(MenuPress);

	}

	void MenuPress()
	{
		SceneManager.LoadScene("MainMenu");
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;


// Home screen images/buttons linked with their respective scenes by way of 'Onclick' function in editor


public class MainController : MonoBehaviour {

    public Button arWildlifeButton;

	// Use this for initialization
	void Start () {
        Button arWildlifeBtn = arWildlifeButton.GetComponent<Button>();
        arWildlifeBtn.onClick.AddListener(ARWPress);
	}
	
    public void ARWPress(){
        SceneManager.LoadScene("ARAnimal");
    }

    public void QuizPress(){
        SceneManager.LoadScene("QuizMenuScene");
    }

    public void MapPress(){
        SceneManager.LoadScene("MapScene");
    }

    public void PhotoPress(){
        SceneManager.LoadScene("PictureBook");
    }

    public void FootagePress(){
        SceneManager.LoadScene("Footage");
    }

    public void EncycPress(){
        SceneManager.LoadScene("Encyclopedia");
    }
		
}

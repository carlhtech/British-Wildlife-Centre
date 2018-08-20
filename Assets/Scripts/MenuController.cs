using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


// Menucontroller links all the homescreen buttons and icons together. (Highlights etc)

public class MenuController : MonoBehaviour {


	public Button homeButton;
    public Button mapButton;
    public Button arButton;
    public Button quizButton;
    public Button photoButton;
    public Button footageButton;
    public Button encycButton;


	public Image homeIcon;
    public Image mapIcon;
    public Image arIcon;
    public Image quizIcon;
    public Image photoIcon;
    public Image footageIcon;
    public Image encycIcon;


	// Use this for initialization
	void Start () {
		Button homeBtn = homeButton.GetComponent<Button> ();
		homeBtn.onClick.AddListener (HomePress);

        Button mapBtn = mapButton.GetComponent<Button>();
		mapBtn.onClick.AddListener(MapPress);

		Button arBtn = arButton.GetComponent<Button>();
		arBtn.onClick.AddListener(ARPress);

		Button quizBtn = quizButton.GetComponent<Button>();
		quizBtn.onClick.AddListener(QuizPress);

        Button photoBtn = photoButton.GetComponent<Button>();
        photoBtn.onClick.AddListener(PhotoPress);

        Button footageBtn = footageButton.GetComponent<Button>();
        footageBtn.onClick.AddListener(FootagePress);

        Button encycBtn = encycButton.GetComponent<Button>();
        encycBtn.onClick.AddListener(EncycPress);



        Screen.orientation = ScreenOrientation.Portrait;
	}
	
    // These below methods are linked to the 'onclick' event and will change the colour of the icons if they correspond to the clicked image/button

	void HomePress(){
		SceneManager.LoadScene ("HomeScreen");
		homeIcon.GetComponent<Image> ().color = new Color32 (0xA1, 0xB2, 0x53, 0xFF);
		homeButton.GetComponentInChildren<Text> ().color = new Color32 (0xA1, 0xB2, 0x53, 0xFF);
	}

	void MapPress()
	{
		SceneManager.LoadScene("MapScene");
		mapIcon.GetComponent<Image>().color = new Color32(0xA1, 0xB2, 0x53, 0xFF);
		mapButton.GetComponentInChildren<Text>().color = new Color32(0xA1, 0xB2, 0x53, 0xFF);
	}

	void ARPress()
	{
		SceneManager.LoadScene("ARAnimal");
		arIcon.GetComponent<Image>().color = new Color32(0xA1, 0xB2, 0x53, 0xFF);
		arButton.GetComponentInChildren<Text>().color = new Color32(0xA1, 0xB2, 0x53, 0xFF);
	}

	void QuizPress()
	{
		SceneManager.LoadScene("QuizMenuScene");
		quizIcon.GetComponent<Image>().color = new Color32(0xA1, 0xB2, 0x53, 0xFF);
		quizButton.GetComponentInChildren<Text>().color = new Color32(0xA1, 0xB2, 0x53, 0xFF);
	}

    void PhotoPress()
    {
        SceneManager.LoadScene("PictureBook");
        photoIcon.GetComponent<Image>().color = new Color32(0xA1, 0xB2, 0x53, 0xFF);
        photoButton.GetComponentInChildren<Text>().color = new Color32(0xA1, 0xB2, 0x53, 0xFF);
    }

    void FootagePress()
    {
        SceneManager.LoadScene("Footage");
        footageIcon.GetComponent<Image>().color = new Color32(0xA1, 0xB2, 0x53, 0xFF);
        footageButton.GetComponentInChildren<Text>().color = new Color32(0xA1, 0xB2, 0x53, 0xFF);
    }

    void EncycPress()
    {
        SceneManager.LoadScene("Encyclopedia");
        encycIcon.GetComponent<Image>().color = new Color32(0xA1, 0xB2, 0x53, 0xFF);
        encycButton.GetComponentInChildren<Text>().color = new Color32(0xA1, 0xB2, 0x53, 0xFF);
    }
}

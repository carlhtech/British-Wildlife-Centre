using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// This script is now not in use but it was designed to enlarge the menu item that is in the center of the page. Creating a nice effect.
// Have discontinued it at the moment as it was a bit of a sticky animation and can be bettered.
// Also contains the original icon colour changes which have now been moved to 'MenuController'

public class MenuEnlarge : MonoBehaviour {

	public GameObject menuAnimal;
	public GameObject menuQuiz;
	public GameObject menuMap;
	public GameObject menuPhoto;
	public GameObject menuFootage;
	public GameObject menuEncyc;

	public Image mapIcon;
	public Image animalIcon;
	public Image quizIcon;
	public Image photoIcon;
	public Image footageIcon;
	public Image encycIcon;

	public GameObject menuTrigger;

	public Text text;

    private float expandTime = 1.0f;


	void OnTriggerEnter2D (Collider2D other){
		if (other.gameObject.tag == ("MenuItem")) {
            //other.transform.localScale += new Vector3(0.2f, 0.2f, 0);
			mapIcon.GetComponent<Image>().color = Color.white;
			animalIcon.GetComponent<Image>().color = Color.white;
			quizIcon.GetComponent<Image>().color = Color.white;
			photoIcon.GetComponent<Image>().color = Color.white;
			footageIcon.GetComponent<Image>().color = Color.white;
			encycIcon.GetComponent<Image>().color = Color.white;

		}
		if (other.gameObject == menuMap) {
			mapIcon.GetComponent<Image> ().color = new Color32 (0xA1, 0xB2, 0x53, 0xFF);
			text.GetComponent<Text> ().text = ("Interactive Map");
		}
		if (other.gameObject == menuAnimal) {
			animalIcon.GetComponent<Image> ().color = new Color32 (0xA1, 0xB2, 0x53, 0xFF);
			text.GetComponent<Text> ().text = ("AR Animal");
		}
		if (other.gameObject == menuQuiz) {
			quizIcon.GetComponent<Image> ().color = new Color32 (0xA1, 0xB2, 0x53, 0xFF);
			text.GetComponent<Text> ().text = ("Quiz");
		}
		if (other.gameObject == menuPhoto) {
			photoIcon.GetComponent<Image> ().color = new Color32 (0xA1, 0xB2, 0x53, 0xFF);
			text.GetComponent<Text> ().text = ("Photo Book");
		}
		if (other.gameObject == menuFootage) {
			footageIcon.GetComponent<Image> ().color = new Color32 (0xA1, 0xB2, 0x53, 0xFF);
			text.GetComponent<Text> ().text = ("AR Footage");
		}
		if (other.gameObject == menuEncyc) {
			encycIcon.GetComponent<Image> ().color = new Color32 (0xA1, 0xB2, 0x53, 0xFF);
			text.GetComponent<Text> ().text = ("Encyclopedia");
		}
	}

	/*void OnTriggerExit2D (Collider2D other){
		if (other.gameObject.tag == ("MenuItem")) {
            other.transform.localScale -= new Vector3(0.2f, 0.2f, 0);
		} 

	}*/
		

}
				
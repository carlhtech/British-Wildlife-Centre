using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Controls the map scene and how the info is displayed

public class MapSceneController : MonoBehaviour {

	public Button[] dots;
	public Button exhibits;
	public Button routes;
	public Button talks;

	public Image arrows;
	public Image otterInfo;
	public Image times;

	public GameObject highlight1;
	public GameObject highlight2;
	public GameObject highlight3;


	private bool exToggle = false;


    // Get button components of the 3 main features on right of the screen

	void Start () {
		Button otterDotBtn = dots[4].GetComponent<Button> ();
		otterDotBtn.onClick.AddListener (OtterDotPress);
		otterInfo.enabled = false;

		Button exhibitsBtn = exhibits.GetComponent<Button> ();
		exhibitsBtn.onClick.AddListener (ExhibitsPress);

		Button routesBtn = routes.GetComponent<Button> ();
		routesBtn.onClick.AddListener (RoutesPress);
		arrows.enabled = false;

		Button talksBtn = talks.GetComponent<Button> ();
		talksBtn.onClick.AddListener (TalksPress);
		times.enabled = false;

		Screen.orientation = ScreenOrientation.LandscapeLeft;

	}
	
	// Display the otter info popup

	void OtterDotPress(){
		if (otterInfo.enabled == true) {
			otterInfo.enabled = false;
			return;
		}
		if (otterInfo.enabled == false) {
			otterInfo.enabled = true;
			return;
		}
	}

    // If exhibits button is pressed then set highlight

	void ExhibitsPress(){

		if (!exToggle) {
			foreach (Button dot in dots) {
				dot.gameObject.SetActive (true);
			}
			highlight1.SetActive (true);
			exToggle = true;
			return;
		} 

		if (exToggle == true) {
			foreach (Button dot in dots) {
				dot.gameObject.SetActive (false);
			}
			highlight1.SetActive (false);
			exToggle = false;
			return;
		} 

	}

    // If routes button is pressed then set highlight

	void RoutesPress(){
		if (arrows.enabled == true) {
			arrows.enabled = false;
			highlight2.SetActive  (false);
			return;
		}
		if (arrows.enabled == false) {
			arrows.enabled = true;
			highlight2.SetActive (true);
			return;
		}
	}

    // If talks button is pressed then set highlight

	void TalksPress(){
		if (times.enabled == true) {
			times.enabled = false;
			highlight3.SetActive  (false);
			return;
		}
		if (times.enabled == false) {
			times.enabled = true;
			highlight3.SetActive (true);
			return;
		}

	}
}


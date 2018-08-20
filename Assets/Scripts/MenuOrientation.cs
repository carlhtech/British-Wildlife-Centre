using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuOrientation : MonoBehaviour {


    // Because there is a mixture of landscape and portrait scenes, I have added orientation instructions on each scene to stop any incorrect orientation which happens when switching between the two

	void Start () {
        Screen.orientation = ScreenOrientation.Portrait;
	}
	
	
}

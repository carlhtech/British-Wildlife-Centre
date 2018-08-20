using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Class to control the AR deer

public class DeerControl : MonoBehaviour {

    public GameObject deer;
    private Animation anim;
    private bool shouldMove = false;

    Animator animator;


    // Will find all relevant animator/animation components

	void Start () {
        anim = deer.GetComponent<Animation>();
        animator = deer.GetComponent<Animator>();
	}
	
    // Simple code to control the movement and speed of the deer. Will always move forward currently from camera

	void Update () {
        if(shouldMove){
            transform.Translate(Vector3.forward * Time.deltaTime *(transform.localScale.x * 0.05f));
        }
	}

    // Walk animation. Trigger has been set in animator component

    public void Walk(){
        if(!anim.isPlaying){
            animator.SetTrigger("Walking");
            anim.Play();
            shouldMove = true;
        }else{
            anim.Stop();
            shouldMove = false;
        }
    }

    // This is relevant to the 'call' button on screen. Will call the deer to the player and place it in front of them

    public void LookAt(){
        transform.LookAt(Camera.main.transform.position);
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);   
    }

    // Increases the deer by a factor of 1 (scale)

    public void Bigger(){
        transform.localScale += new Vector3(1, 1, 1);
    }

    // Decreases the deer size by a factor of 1 (scale)

	public void Smaller(){

        if (transform.localScale.x > 1)
        {
            transform.localScale -= new Vector3(1, 1, 1);
        }
	}
}

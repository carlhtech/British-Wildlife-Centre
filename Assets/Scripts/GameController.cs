using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


// Fairly large script to control the quiz questions, answers, score and time behaviours

public class GameController : MonoBehaviour
{


    public Image questionText;

    public Sprite[] questions;

    public Button aHighlight;
    public Button bHighlight;
    public Button cHighlight;

    public Sprite correctHighlight;
    public Sprite wrongHighlight;
    public Sprite noHighlight;

    public Text answerA;
    public Text answerB;
    public Text answerC;

    private bool aClicked = false;
    private bool bClicked = false;
    private bool cClicked = false;

    public Text timeDisplay;
    public Text scoreDisplay;
    private float timeRemaining;
    private int playerScore;

    private bool q1Active = true;
    private bool q2Active = false;
    private bool q3Active = false;
    private bool q4Active = false;
    private bool q5Active = false;
    private bool q6Active = false;
    private bool q7Active = false;
    private bool q8Active = false;


    // Will start the quiz off and set the images to the first question
    // Also setting time and score defaults here

    void Start()
    {
		Button btnA = aHighlight.GetComponent<Button>();
		btnA.onClick.AddListener(ClickedA);
        Button btnB = bHighlight.GetComponent<Button>();
		btnB.onClick.AddListener(ClickedB);
		Button btnC = cHighlight.GetComponent<Button>();
		btnC.onClick.AddListener(ClickedC);

		questionText.GetComponent<Image>().sprite = questions[0];
		answerA.text = "A\tSlow worm";
		answerB.text = "B\tSmooth Snake";
		answerC.text = "C\tHorned viper";

        playerScore = 0;
        timeRemaining = 59;

    }


    // Update function contains 'correct' question data and highlight data. 
    // It runs coroutines from the bottom of the script to set the next question/answer data

    private void Update()
    {
        timeRemaining -= Time.deltaTime;
        timeDisplay.text = timeRemaining.ToString("f0");



		if (q1Active == true)
        {
			if (aClicked == true)
			{
				aHighlight.GetComponent<Image>().sprite = wrongHighlight;
				aClicked = false;
				StartCoroutine(WaitQ1());
			}
            if (bClicked == true)
            {
                bHighlight.GetComponent<Image>().sprite = correctHighlight;
                UpdateScore();
                bClicked = false;
                StartCoroutine(WaitQ1());
            }
            if (cClicked == true)
            {
                cHighlight.GetComponent<Image>().sprite = wrongHighlight;
                cClicked = false;
                StartCoroutine(WaitQ1());
            }
        }
		
       
        if (q2Active == true)
        {
            if (aClicked == true)
            {
                aHighlight.GetComponent<Image>().sprite = correctHighlight;
                UpdateScore();
                aClicked = false;
                StartCoroutine(WaitQ2());
            }
            if (bClicked == true)
            {
                bHighlight.GetComponent<Image>().sprite = wrongHighlight;
                bClicked = false;
				StartCoroutine(WaitQ2());
            }
            if (cClicked == true)
            {
                cHighlight.GetComponent<Image>().sprite = wrongHighlight;
                cClicked = false;
				StartCoroutine(WaitQ2());
            }
        }

        if (q3Active == true)
		{
			if (aClicked == true)
			{
				aHighlight.GetComponent<Image>().sprite = wrongHighlight;
				aClicked = false;
				StartCoroutine(WaitQ3());
			}
			if (bClicked == true)
			{
				bHighlight.GetComponent<Image>().sprite = correctHighlight;
                UpdateScore();
				bClicked = false;
				StartCoroutine(WaitQ3());
			}
			if (cClicked == true)
			{
				cHighlight.GetComponent<Image>().sprite = wrongHighlight;
				cClicked = false;
                StartCoroutine(WaitQ3());
			}
		}

		if (q4Active == true)
		{
			if (aClicked == true)
			{
				aHighlight.GetComponent<Image>().sprite = wrongHighlight;
				aClicked = false;
                StartCoroutine(WaitQ4());
			}
			if (bClicked == true)
			{
				bHighlight.GetComponent<Image>().sprite = wrongHighlight;
				bClicked = false;
                StartCoroutine(WaitQ4());
			}
			if (cClicked == true)
			{
                cHighlight.GetComponent<Image>().sprite = correctHighlight;
                UpdateScore();
				cClicked = false;
                StartCoroutine(WaitQ4());
			}
		}

        if (q5Active == true)
		{
			if (aClicked == true)
			{
				aHighlight.GetComponent<Image>().sprite = correctHighlight;
                UpdateScore();
				aClicked = false;
                StartCoroutine(WaitQ5());
			}
			if (bClicked == true)
			{
                bHighlight.GetComponent<Image>().sprite = wrongHighlight;
				bClicked = false;
                StartCoroutine(WaitQ5());
			}
			if (cClicked == true)
			{
				cHighlight.GetComponent<Image>().sprite = wrongHighlight;
				cClicked = false;
                StartCoroutine(WaitQ5());
			}
		}

        if (q6Active == true)
		{
			if (aClicked == true)
			{
				aHighlight.GetComponent<Image>().sprite = wrongHighlight;
				aClicked = false;
				StartCoroutine(WaitQ6());
			}
			if (bClicked == true)
			{
				bHighlight.GetComponent<Image>().sprite = correctHighlight;
                UpdateScore();
				bClicked = false;
				StartCoroutine(WaitQ6());
			}
			if (cClicked == true)
			{
				cHighlight.GetComponent<Image>().sprite = wrongHighlight;
				cClicked = false;
				StartCoroutine(WaitQ6());
			}
		}

        if (q7Active == true)
		{
			if (aClicked == true)
			{
				aHighlight.GetComponent<Image>().sprite = wrongHighlight;
				aClicked = false;
				StartCoroutine(WaitQ7());
			}
			if (bClicked == true)
			{
				bHighlight.GetComponent<Image>().sprite = correctHighlight;
                UpdateScore();
				bClicked = false;
				StartCoroutine(WaitQ7());
			}
			if (cClicked == true)
			{
				cHighlight.GetComponent<Image>().sprite = wrongHighlight;
				cClicked = false;
				StartCoroutine(WaitQ7());
			}
		}
    }


    // Booleans to control which buttons are being pressed

	public void ClickedA()
	{
		aClicked = true;
	}

	public void ClickedB()
	{
		bClicked = true;
	}

	public void ClickedC()
	{
		cClicked = true;
	}

    // Will update the score on the screen if the question is deemed correct

    public void UpdateScore(){
        playerScore++;
        scoreDisplay.text = playerScore.ToString();
    }

    // Several coroutines which will allow time before the next question is set, highlights are triggered and answers set

	IEnumerator WaitQ1()
	{
		yield return new WaitForSeconds(1.0f);
		questionText.GetComponent<Image>().sprite = questions[1];
		answerA.text = "A\tSett";
		answerB.text = "B\tBurrow";
		answerC.text = "C\tDen";
        aHighlight.GetComponent<Image>().sprite = noHighlight;
        bHighlight.GetComponent<Image>().sprite = noHighlight;
        cHighlight.GetComponent<Image>().sprite = noHighlight;
        q1Active = false;
        q2Active = true;
	}

	IEnumerator WaitQ2()
	{
		yield return new WaitForSeconds(1.0f);
		questionText.GetComponent<Image>().sprite = questions[2];
		answerA.text = "A\tPiglets";
		answerB.text = "B\tHoglets";
		answerC.text = "C\tPups";
		aHighlight.GetComponent<Image>().sprite = noHighlight;
		bHighlight.GetComponent<Image>().sprite = noHighlight;
		cHighlight.GetComponent<Image>().sprite = noHighlight;
        q2Active = false;
        q3Active = true;
	}

	IEnumerator WaitQ3()
	{
		yield return new WaitForSeconds(1.0f);
		questionText.GetComponent<Image>().sprite = questions[3];
		answerA.text = "A\tRed";
		answerB.text = "B\tRoe";
		answerC.text = "C\tFallow";
		aHighlight.GetComponent<Image>().sprite = noHighlight;
		bHighlight.GetComponent<Image>().sprite = noHighlight;
		cHighlight.GetComponent<Image>().sprite = noHighlight;
        q3Active = false;
        q4Active = true;
	}

	IEnumerator WaitQ4()
	{
		yield return new WaitForSeconds(1.0f);
		questionText.GetComponent<Image>().sprite = questions[4];
		answerA.text = "A\tPolecat";
		answerB.text = "B\tStoat";
		answerC.text = "C\tFerret";
		aHighlight.GetComponent<Image>().sprite = noHighlight;
		bHighlight.GetComponent<Image>().sprite = noHighlight;
		cHighlight.GetComponent<Image>().sprite = noHighlight;
        q4Active = false;
        q5Active = true;
	}

	IEnumerator WaitQ5()
	{
		yield return new WaitForSeconds(1.0f);
		questionText.GetComponent<Image>().sprite = questions[5];
		answerA.text = "A\tRed Kite";
		answerB.text = "B\tBuzzard";
		answerC.text = "C\tKestrel";
		aHighlight.GetComponent<Image>().sprite = noHighlight;
		bHighlight.GetComponent<Image>().sprite = noHighlight;
		cHighlight.GetComponent<Image>().sprite = noHighlight;
		q5Active = false;
        q6Active = true;
	}

	IEnumerator WaitQ6()
	{
		yield return new WaitForSeconds(1.0f);
		questionText.GetComponent<Image>().sprite = questions[6];
		answerA.text = "A\tSame Size";
		answerB.text = "B\tSmaller";
		answerC.text = "C\tLarger";
		aHighlight.GetComponent<Image>().sprite = noHighlight;
		bHighlight.GetComponent<Image>().sprite = noHighlight;
		cHighlight.GetComponent<Image>().sprite = noHighlight;
		q6Active = false;
		q7Active = true;
	}

	IEnumerator WaitQ7()
	{
		yield return new WaitForSeconds(1.0f);
		questionText.GetComponent<Image>().sprite = questions[7];
		answerA.text = "A\tCarnivorous";
		answerB.text = "B\tOmnivorous";
		answerC.text = "C\tHerbivorous";
		aHighlight.GetComponent<Image>().sprite = noHighlight;
		bHighlight.GetComponent<Image>().sprite = noHighlight;
		cHighlight.GetComponent<Image>().sprite = noHighlight;
		q7Active = false;
		q8Active = true;
	}
   
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max, min, guess;

    // Use this for initialization
    void Start ()
    {
        StartGame();
	}

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
        Debug.Log("Welcome to Number Wizard!");
        Debug.Log("Pick a number and I will take forever to guess it...");
        Debug.Log("The highest number that I can handle is " + max);
        Debug.Log("The lowest number that I can handle is " + min);
        Debug.Log("Start by telling me if your number is higher or lower than " + guess);
        Debug.Log("Push Up if it's Higher, Push Down if it's Lower, Push Enter if it's Correct, Push Space if it's Incorrect");
        max = max + 1;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Is your number higher than or lower than " + guess + "?");
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I Win! You Loose!");
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is your number " + guess + "?");
    }
}

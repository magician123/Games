using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstProject : MonoBehaviour
{   
    int maxNumber;
    int minNumber;
    int guess;
    void Start()
    {
        StartGame();
    
    }

    private void StartGame()
    {
        maxNumber = 1000;
        minNumber = 1;
        guess = 500; 

        Debug.Log("Welcome to number wizard");
        Debug.Log("Pick a number");
        Debug.Log($"The highest number is {maxNumber} ");
        Debug.Log($"The lowest number is {minNumber} ");
        Debug.Log("Is the number higher or lower than 500?");
        Debug.Log("Press Up = Higher, Press Down = Lower, Press Enter= Correct");

        maxNumber += 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            minNumber = guess;
            guess = GuessedNumer(minNumber,maxNumber);

            Debug.Log($"Is higher or lower than {guess}");
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
  
            maxNumber = guess;
            guess = GuessedNumer(minNumber, maxNumber);

            Debug.Log($"Is higher or lower than {guess}");
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("The Enter Key Ws pressed");
            StartGame();
        }
       
    }

    int GuessedNumer(int min, int max)
    {
        return (min + max) / 2;
    }
}

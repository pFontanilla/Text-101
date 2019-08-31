using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{

    static int min = 0, max = 100;
    int guess = 0;

    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("Welcome to number wizard!");
        Debug.Log(string.Format("Pick any number within the following range: {0} - {1}, inclusive.", min, max));
        Debug.Log("I am going to deduce your chosen number with your help.");
        Debug.Log("Press the 'Up Arrow' if your number is higher than my guess.");
        Debug.Log("Press the 'Down Arrow' if your number is lower than my guess.");
        Debug.Log("Press the 'Return Key' if my guess is correct!");
        guess = (max + min) / 2;
        Debug.Log("My Guess is " + guess);
    }

    // Provide new guess
    void NewGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("My New Guess is " + guess);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Your number is higher than my guess!");
            min = guess;
            NewGuess();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Your number is lower than my guess!");
            max = guess;
            NewGuess();
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("We did it!!");
        }
    }
}

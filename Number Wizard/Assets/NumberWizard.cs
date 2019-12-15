using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {
    
    int min = 1;
    int max = 1000;
    int guess = 500;
    
    void Start() {
        StartGame();
    }

    void StartGame() {
        Debug.Log("Welcome to number wizard :D");
        Debug.Log("Please pick a number");
        Debug.Log("Lower Number : " + min);
        Debug.Log("Higherst Number : " + max);
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Press up = higher, Press down = lower, Push Return = Correct");
        max += 1;
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            min = guess;
            guess = takeGuess();
            Debug.Log("Tell me if your number is higher or lower than " + guess);
        } else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            max = guess;
            guess = takeGuess();
            Debug.Log("Tell me if your number is higher or lower than " + guess);
        } else if (Input.GetKeyDown(KeyCode.Return)) {
            Debug.Log("Yayyyy !! Your number was " + guess + " I am so smart :3");
        }
    }

    int takeGuess() {
        return (max + min) / 2;
    }
}

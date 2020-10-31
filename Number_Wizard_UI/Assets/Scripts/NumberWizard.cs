using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{

    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;


    int guess;

    // Use this for initialization
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        NextGuess();
    }

    // Update is called once per frame
    public void onPressHigher()
    {
        min = guess + 1;
        NextGuess();

    }
    public void onPressLower()
    {
        max = guess - 1;
        NextGuess();

    }

    void NextGuess()
    {
        guess = Random.Range(min, max + 1);
        if (guess > max)
        {
            guess = max;
        }
        else
        {
            guessText.text = guess.ToString();
        }
    }
}

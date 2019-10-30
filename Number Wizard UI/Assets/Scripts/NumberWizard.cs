using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int min;
    [SerializeField] int max;
    [SerializeField] TextMeshProUGUI guessText;

    private int minNumber;
    private int maxNumber;
    private int guess;

    // Start is called before the first frame update
    void Start()
    {
        initialize();
    }

    // Update is called once per frame

    void initialize()
    {
        minNumber = min;
        maxNumber = max; // make max inclusive
        nextGuess();
    }

    public void guessHigher()
    {
        minNumber = maxNumber <= minNumber ? maxNumber : guess + 1; // exclude current min from future guesses
        nextGuess();
    }

    public void guessLower()
    {
        maxNumber = minNumber >= maxNumber ? maxNumber : guess - 1; // exclude current max from future guesses
        nextGuess();
    }

    void nextGuess()
    {
        guess = Random.Range(minNumber, maxNumber + 1); // make sure the guess is inclusive
        guessText.text = guess.ToString();
    }

    void gameOver()
    {
        initialize();
    }
}

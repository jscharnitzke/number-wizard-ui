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
        guess = average(minNumber, maxNumber);
        guessText.text = guess.ToString();
    }

    public void guessHigher()
    {
        minNumber = guess;
        nextGuess();
    }

    public void guessLower()
    {
        maxNumber = guess;
        nextGuess();
    }

    void nextGuess()
    {
        guess = average(minNumber, maxNumber);
        guessText.text = guess.ToString();
    }

    int average(int a, int b)
    {
        return (a + b) / 2;
    }

    void gameOver()
    {
        initialize();
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Random = UnityEngine.Random;

public class Exercise04 : MonoBehaviour
{
    public GameObject resultsPanel;
    public TextMeshProUGUI attemptsText, rightText, wrongText;
    
    private int totalAttempts = 1;
    private int rightCounter;

    public void SelectOption(int option)
    {
        int currentOption = RandomOption();
        totalAttempts++;
        attemptsText.text = $"Attempt: {totalAttempts}";
        if (currentOption == option)
        {
            rightCounter++;
        }

        if (totalAttempts >= 10)
        {
            ShowResults();
        }
    }

    private int RandomOption()
    {
        return Random.Range(0, 2);
    }

    private void ShowResults()
    {
        resultsPanel.SetActive(true);
        rightText.text = $"Right: {rightCounter}";
        wrongText.text = $"Wrong: {totalAttempts - rightCounter}";
    }
}

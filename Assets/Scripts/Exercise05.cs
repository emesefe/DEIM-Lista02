using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.Mathematics;
using Random = UnityEngine.Random;

public class Exercise05 : MonoBehaviour
{
    public Sprite[] sprites;
    public string[] horoscope;
    public Image img;
    public TextMeshProUGUI text;


    private int year;


    public void SubmitYear(string y)
    {
        year = int.Parse(y);
        int animal = year % 12;
        img.sprite = sprites[animal];
        text.text = $"Year {year} - {horoscope[animal]}";
    }
}

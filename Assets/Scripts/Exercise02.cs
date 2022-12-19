using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exercise02 : MonoBehaviour
{
    public int totalTime = 10;

    private Image _image;
    private int currentTime;

    private void Start()
    {
        _image = GetComponent<Image>();
        currentTime = totalTime;
        StartCoroutine(Timer());
    }

    private IEnumerator Timer()
    {
        while (currentTime > 0)
        {
            yield return new WaitForSeconds(1);
            currentTime--;
            _image.fillAmount = (float) currentTime  / totalTime;
        }
    }
}

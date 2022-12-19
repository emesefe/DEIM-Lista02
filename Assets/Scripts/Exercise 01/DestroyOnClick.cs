using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnClick : MonoBehaviour
{
    private Exercise01 exercise01;

    private void Start()
    {
        exercise01 = FindObjectOfType<Exercise01>();
    }

    private void OnMouseDown()
    {
        exercise01.DestroyedEnemy();
        Destroy(gameObject);
    }
}

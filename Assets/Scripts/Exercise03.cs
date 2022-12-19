using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Random = UnityEngine.Random;

public class Exercise03 : MonoBehaviour
{
    public int bound = 2;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Move(Vector3.up);
        }else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Move(Vector3.down);
        }else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Move(Vector3.right);
        }else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Move(Vector3.left);
        }
    }

    private bool PlayerInBounds(Vector3 newPos)
    {
        if (newPos.x < -bound || newPos.x > bound ||
            newPos.y < -bound || newPos.y > bound)
        {
            return false;
        }

        return true;
    }

    private void Move(Vector3 dir)
    {
        if (PlayerInBounds(transform.position + dir))
        {
            transform.Translate(dir);
        }
    }
}

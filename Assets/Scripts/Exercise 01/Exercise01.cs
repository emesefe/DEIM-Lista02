using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Random = UnityEngine.Random;

public class Exercise01 : MonoBehaviour
{
    public GameObject enemy;

    private int enemiesPerWave = 1;
    private int totalEnemiesInScene;

    private float xLim = 10;
    private float yLim = 5;
    private Vector2 zLim = new Vector2(0, 5);

    private void Start()
    {
        totalEnemiesInScene = enemiesPerWave;
        GenerateNewWave();
    }

    public void DestroyedEnemy()
    {
        totalEnemiesInScene--;

        if (totalEnemiesInScene <= 0)
        {
            enemiesPerWave++;
            totalEnemiesInScene = enemiesPerWave;
            GenerateNewWave();
        }
    }

    private void GenerateNewWave()
    {
        for (int i = 0; i < enemiesPerWave; i++)
        {
            Instantiate(enemy, RandomPositionInSceneLimits(), Quaternion.identity);
        }
    }

    private Vector3 RandomPositionInSceneLimits()
    {
        float x = Random.Range(-xLim, xLim);
        float y = Random.Range(-yLim, yLim);
        float z  = Random.Range(zLim[0], zLim[1]);
        
        return new Vector3(x, y, z);
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LifeCounter : MonoBehaviour
{
    // Life prefab
    public GameObject lifePrefab;

    private List<GameObject> lives;

 
    public void SetLives(int amount)
    {
        

        lives = new List<GameObject>();
        for (int i = 0; i < amount; i++)
        {
            GameObject lifeInstance = Instantiate(lifePrefab, transform);
            lives.Add(lifeInstance);
        }
    }

    public void LoseLife()
    {
        GameObject lastLife = lives[lives.Count - 1];
        lives.Remove(lastLife);
        Destroy(lastLife);
    }
}

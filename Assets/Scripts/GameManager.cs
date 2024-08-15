﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
        }
        DontDestroyOnLoad(this);
    }

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            ChangeScene("Game");
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            ChangeScene("Menu");
        }
    }

    public void ChangeScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
}


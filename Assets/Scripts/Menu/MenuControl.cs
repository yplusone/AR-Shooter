﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("MainGame");
    }

    public void ReStartGame()
    {
        SceneManager.LoadScene("MainGame");
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Type1Menu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Type1-first");
    }
}

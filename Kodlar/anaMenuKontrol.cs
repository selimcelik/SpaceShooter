﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class anaMenuKontrol : MonoBehaviour
{
    
    public void oyunaBasla()
    {
        SceneManager.LoadScene("1");
    }

    public void Oyundancik()
    {
        Application.Quit();
    }
       
}

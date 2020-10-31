using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public void ChooseCharacter()
    {
        SceneManager.LoadScene("Choose Character");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

 
  
}

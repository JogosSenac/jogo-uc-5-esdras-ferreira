using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Começar()
    {
         SceneManager.LoadScene("Inicio");
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("SAIU");
    }
}

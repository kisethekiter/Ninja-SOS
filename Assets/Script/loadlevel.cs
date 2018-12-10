using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadlevel : MonoBehaviour
{
    public void LoadScene(string name)
    {
        Application.LoadLevel(name);
    }

    public void Quitgame()
    {
        Application.Quit();
    }
}
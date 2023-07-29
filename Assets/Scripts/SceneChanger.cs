using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(2);
    }
    public void onQuit()
    {
        Application.Quit();
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(1);
    }
    public void Credits()
    {
        SceneManager.LoadScene(0);
    }
}

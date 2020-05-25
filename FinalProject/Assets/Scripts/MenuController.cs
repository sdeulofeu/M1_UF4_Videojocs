using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    // Start is called before the first frame update
    public void MainMenuPlay()
    {
        SceneManager.LoadScene("Menu2");
    }

    public void SecndMenuPlaySolo()
    {
        SceneManager.LoadScene("01");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void About()
    {
        SceneManager.LoadScene("About");
    }
}

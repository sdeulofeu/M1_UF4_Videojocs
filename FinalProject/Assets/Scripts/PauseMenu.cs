using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using Debug = UnityEngine.Debug;

public class PauseMenu : MonoBehaviour
{
    public static bool paused = false;
    public GameObject pauseMenuUI;
    public FirstPersonAIO player;
   
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            player.enableCameraMovement = false;           
            if (paused)
            {
                Resume();
            }
            else Pause();
        }
    }

    public void Resume()
    {
        player.lockAndHideCursor = false;
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        paused = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;       
    }
    
    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    void Pause()
    {
        player.lockAndHideCursor = true;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        paused = true;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void SecndMenuPlaySolo()
    {
        SceneManager.LoadScene("01");
    }
}

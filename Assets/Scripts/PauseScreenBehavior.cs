using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScreenBehavior : MainMenuBehavior
{
    static public bool paused;
    [Tooltip("Reference to the pause meny object to turn on/off")]
    public GameObject pauseMenu;

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void SetPauseMenu(bool isPaused)
    {
        paused = isPaused;
        pauseMenu.SetActive(paused);
        Time.timeScale = (paused) ? 0 : 1;
        
    }

    void Start()
    {
        SetPauseMenu(false);
    }
}

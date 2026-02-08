using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class LogicScripts : MonoBehaviour
{
    public bool isPaused = false;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Continue();
            }
            else
            {
                Pause();
            }
        }
    }

    public GameObject GameOverScreen;
    public GameObject PauseScreen;

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }

    public void GameOver()
    {
        GameOverScreen.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Pause()
    {
        PauseScreen.SetActive(true);
        isPaused = true;
        Time.timeScale = 0f;
    }

    public void Continue()
    {
        PauseScreen.SetActive(false);
        isPaused = false;
        Time.timeScale = 1f;
    }

    public void MainMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }
}

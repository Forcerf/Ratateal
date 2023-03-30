using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Sciptmenu : MonoBehaviour
{
    public GameObject PauseMenu;

    public static bool isPause;

    void Start()
    {
        PauseMenu.SetActive(false);
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPause)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPause = true;
    }
    public void ResumeGame()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPause = false;
    }

    public void Restart()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene("SampleScene");
        isPause = false;
    }

    public void quitGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Start");

    }
}

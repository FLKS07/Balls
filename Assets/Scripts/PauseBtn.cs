using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseBtn : MonoBehaviour
{
    public GameController gameController;

    public GameObject pausePanel;



    public void pauseButton()
    {
        if (gameController.isPaused == true)
        {
            gameController.isPaused = false;
            Time.timeScale = 1f;
            pausePanel.SetActive(false);
        }
        else if (gameController.isPaused == false)
        {
            gameController.isPaused = true;
            Time.timeScale = 0f;
            pausePanel.SetActive(true);
        }


    }
}

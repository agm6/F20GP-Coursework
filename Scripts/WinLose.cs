using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLose : MonoBehaviour
{
    private bool gameEnded;
    public GameObject winPanel;
    public GameObject losePanel;
    public GameObject timer;
    public AudioSource gameMusic;
    public AudioSource winMusic;
    public AudioSource loseMusic;

    void Start()
    {
        gameMusic.Play();
    }

    public void winLevel()
    {
        if (!gameEnded)
        {
            //Debug.Log("You Win!");
            winPanel.SetActive(true);
            gameEnded = true;
            timer.SetActive(false);
            if (gameMusic.isPlaying)
            {
                gameMusic.Stop();
                winMusic.Play();
            }
        }
    }

    public void restartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void loadMainMenu()
    {
        SceneManager.LoadScene("Main_Menu");
    }

    public void loseLevel()
    {
        if (!gameEnded)
        {
            //Debug.Log("You Lose!");
            //restartLevel();
            losePanel.SetActive(true);
            gameEnded = true;
            timer.SetActive(false);
            if (gameMusic.isPlaying)
            {
                gameMusic.Stop();
                loseMusic.Play();
            }
        }
    }
}

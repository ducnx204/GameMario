using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePauReloadScenn : MonoBehaviour
{

    public GameObject gamePauseText;
    public bool isGamePause = false;
    public void Pause()
    {
        Time.timeScale = 0;
        gamePauseText.SetActive(true);
        isGamePause = true;
    }
    public void RePlayPause()
    {
        Time.timeScale = 1;
        isGamePause = false;
        gamePauseText.SetActive(false);

    }
    public void ReLoadPause()
    {
        Time.timeScale = 1;
        isGamePause = false;
        gamePauseText.SetActive(false);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

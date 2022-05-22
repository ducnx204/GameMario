using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReeloadCurrentScene : MonoBehaviour
{
    public void ReloadScene()
    {
        if (GameControll.instance.isGameOver)
        {
            Time.timeScale = 1;
            GameControll.instance.isGameOver = false;

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
    }    
}

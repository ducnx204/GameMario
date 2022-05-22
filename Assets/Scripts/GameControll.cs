using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControll : MonoBehaviour
{
    public static GameControll instance;
    public Text scoreText;
    public Text gameOverScoreText;
    public GameObject gameOverText;
    public bool isGameOver = false;

    private int score = 0;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if(instance == this)
        {
            Destroy(gameObject);

        }
    }
    public void AddScore(int score)
    {
        this.score += score;
        scoreText.text = "" + this.score;

    }
    public void GameOver()
    {
        gameOverScoreText.text = "Score:" + this.score;
        gameOverText.SetActive(true);
        isGameOver = true;

    }
    
    

}

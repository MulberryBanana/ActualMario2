using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameGui : MonoBehaviour
{
    public static GameGui Instance;
    
    private int coins = 0;
    private int score = 0;

    public Text coinText;
    public Text scoreText;
    public Text highScoreText;



    void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        coins = 0;
        SyncUi();
    }

    public void AddCoins(int coinsAmnt)
    {
        coins += coinsAmnt;
        SyncUi();
    }
    public void AddScore(int scoreAmnt)
    {
        score += scoreAmnt;
        SyncUi();
    }

    void SyncUi()
    {
        coinText.text = coins.ToString("00");
        scoreText.text = score.ToString("000000");

        int hiScore = PlayerPrefs.GetInt("BestScore",0);
        if (score > hiScore)
        {
            hiScore = score;
            PlayerPrefs.SetInt("BestScore", score);
            PlayerPrefs.Save();
        }
        highScoreText.text = hiScore.ToString("000000");
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameGui : MonoBehaviour
{
    public static GameGui Instance;
    
    private int coins = 0;
    private int score = 0;

    private int oneup = 0;
    private int mushroom = 0;
    private int fireflower = 0;
    private int star = 0;

    public Text oneupText;
    public Text mushroomText;
    public Text fireflowerText;
    public Text starText;
    public Text coinText;
    public Text scoreText;


    void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        oneup = 0;
        mushroom = 0;
        fireflower = 0;
        star = 0;
        coins = 0;
        SyncUi();
    }
    public void AddOneup()
    {
        oneup += 1;
        SyncUi();
    }
    public void AddMushroom()
    {
        mushroom += 1;
        SyncUi();
    }
    public void AddFireflower()
    {
        fireflower += 1;
        SyncUi();
    }
    public void AddStar()
    {
        star += 1;
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
        oneupText.text = oneup.ToString("00");
        mushroomText.text = mushroom.ToString("00");
        fireflowerText.text = fireflower.ToString("00");
        starText.text = star.ToString("00");
        coinText.text = coins.ToString("00");
        scoreText.text = score.ToString("000000");
    }


}

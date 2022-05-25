using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionCoin : Hittable
{
    public int CoinAmount = 1;
    public bool isBreakable = false;
    public bool spawnsItem = false;
    public int score = 200;
    public GameObject spawnObject;
    protected override void ProcessHit()
    {

        if (CoinAmount > 0) {
            GameGui.Instance.AddCoins(1);
            GameGui.Instance.AddScore(score);
            CoinAmount--;
            //TODO replace sprite? disable?
        }else if (isBreakable)
        {
            //spawn break particles
            Destroy(gameObject);
        }else if (spawnsItem)
        {
            GameObject.Instantiate(spawnObject, gameObject.GetComponent<Renderer>().bounds.center + Vector3.up,transform.rotation);
            spawnsItem = false;
        }
    }
}
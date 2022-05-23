using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionCoin : Hittable
{
    public int hitAmount = 1;
    public bool isBreakable = false;
    protected override void ProcessHit()
    {
        if (hitAmount > 0) {
            GameGui.Instance.AddCoins(1);
            GameGui.Instance.AddScore(200);
            hitAmount--;
            //TODO replace sprite? disable?
        }else if (isBreakable)
        {
            //spawn break particles
            Destroy(gameObject);
        }
    }
}
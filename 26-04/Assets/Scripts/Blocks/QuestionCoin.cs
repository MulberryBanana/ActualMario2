using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionCoin : Hittable
{
    public int CoinAmount = 1;
    public bool isBreakable = false;
    public bool spawnsItem = false;
    public int score = 200;
    public List<GameObject> spawnObjects = new List<GameObject>();
    protected override void ProcessHit()
    {

        if (CoinAmount > 0) {
            GameGui.Instance.AddCoins(1);
            GameGui.Instance.AddScore(score);
            CoinAmount--;
            //gameObject.GetComponent<Animation>().Play();
        } else if (spawnsItem)
        {
            int index = Random.Range(0, spawnObjects.Count);
            GameObject.Instantiate(spawnObjects[index], gameObject.GetComponent<Renderer>().bounds.center + Vector3.up,transform.rotation);
            spawnsItem = false;
        } else if (isBreakable)
        {
            //spawn break particles
            Destroy(gameObject);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : Collectable
{
    protected override void ProcessCollect()
    {
        //GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStates>().isStarman = true;
    }
}

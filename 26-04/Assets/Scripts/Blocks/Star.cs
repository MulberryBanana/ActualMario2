using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : Collectable
{
    protected override void ProcessCollect()
    {
      
        CharacterMovement.Instance.Starman();
        //GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterMovement>().Starman();
    }
}

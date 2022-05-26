using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : Collectable
{
    protected override void ProcessCollect()
    {
      
        CharacterMovement.Instance.Starman();
        GameGui.Instance.AddStar();
    }
}

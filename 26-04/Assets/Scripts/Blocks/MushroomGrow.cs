using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomGrow : Collectable
{
    protected override void ProcessCollect() 
    { 
        CharacterMovement.Instance.isBigMario = true;
        GameGui.Instance.AddMushroom();
    }
}

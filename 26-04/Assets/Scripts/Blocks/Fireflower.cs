using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireflower : Collectable
{
    protected override void ProcessCollect()
    {
        CharacterMovement.Instance.isFireMan = true;
    }
}

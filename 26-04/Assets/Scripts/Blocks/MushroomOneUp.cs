using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomOneUp : Collectable
{
    protected override void ProcessCollect()
    {
        GameGui.Instance.AddOneup();
    }
}

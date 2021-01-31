using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stick : InteractableObject
{
    protected override void CollectMe()
    {
        _inventory.CollectItem(itemID);
        base.CollectMe();
    }
}

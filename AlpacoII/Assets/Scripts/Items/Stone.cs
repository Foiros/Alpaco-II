using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : InteractableObject
{
    protected override void CollectMe()
    {
        _inventory.CollectItem(itemID);
        base.CollectMe();
    }
}

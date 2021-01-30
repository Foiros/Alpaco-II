using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torch : InteractableObject
{
    protected override void CollectMe() { _inventory.CollectItem(itemID); base.CollectMe(); }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BondPuzzle : Puzzle
{
    public GameObject placementObject;
    
    protected override void PuzzleHasBeenSolved()
    {
        base.PuzzleHasBeenSolved();
        _inventory.CollectItem(5);
        placementObject.SetActive(false);
    }
}

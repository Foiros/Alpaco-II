using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigPuzzle : Puzzle
{
    public GameObject pig;
    
    protected override void PuzzleHasBeenSolved()
    {
        base.PuzzleHasBeenSolved();
        _inventory.CollectItem(6);
        pig.SetActive(false);
    }
}

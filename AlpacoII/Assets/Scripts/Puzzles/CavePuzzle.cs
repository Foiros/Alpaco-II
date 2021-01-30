using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CavePuzzle : Puzzle
{
    public GameObject placeToPutTheTorch, litTorch;
    
    protected override void PuzzleHasBeenSolved()
    {
        base.PuzzleHasBeenSolved();
        
        placeToPutTheTorch.SetActive(false);
        litTorch.SetActive(true);
    }
}

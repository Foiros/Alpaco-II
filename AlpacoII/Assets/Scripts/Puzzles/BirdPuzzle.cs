using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdPuzzle : Puzzle
{
    public GameObject bird;

    protected override void PuzzleHasBeenSolved()
    {
        base.PuzzleHasBeenSolved();
        bird.SetActive(false);
    }
}

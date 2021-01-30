using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Puzzle : MonoBehaviour
{
    public int puzzleID, itemID;
    
    private bool puzzleHasBeenSolved, canBeInteracted;
    
    private Inventory _inventory;

    protected void Awake() { _inventory = GameObject.FindGameObjectWithTag("GameController").GetComponent<Inventory>(); }

    protected void Update() { PuzzleCondition(itemID); }
    
    protected void OnTriggerEnter2D(Collider2D other) { if (other.CompareTag("Player")) { canBeInteracted = true; } }

    protected void OnTriggerExit2D(Collider2D other) { canBeInteracted = false; }
    
    private void PuzzleCondition(int itemID)
    {
        if (canBeInteracted && Input.GetMouseButtonDown(0) && _inventory.itemsGathered[itemID])
        {
            _inventory.UseItem(puzzleID);
            PuzzleHasBeenSolved();
        }
    }
    
    protected virtual void PuzzleHasBeenSolved() { _inventory.RescueAlpaca(); }
}

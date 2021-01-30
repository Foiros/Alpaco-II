using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InteractableObject : MonoBehaviour
{
    public int itemID;
    private bool canBeInteracted;
    protected Inventory _inventory;

    protected void Awake() { _inventory = GameObject.FindGameObjectWithTag("GameController").GetComponent<Inventory>(); }

    protected void OnTriggerEnter2D(Collider2D other) { if (other.CompareTag("Player")) { canBeInteracted = true; } }

    protected void OnTriggerExit2D(Collider2D other) { canBeInteracted = false; }

    protected void Update() { if (canBeInteracted && Input.GetMouseButtonDown(0)) { CollectMe(); } }

    protected virtual void CollectMe() { Destroy(gameObject);}
}

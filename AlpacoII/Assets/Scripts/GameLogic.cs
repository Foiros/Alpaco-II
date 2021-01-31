using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLogic : MonoBehaviour
{
    public GameObject victoryBanner;

    public int alpacasToRescue;
    
    private Inventory _inventory;

    private void Awake() { _inventory = GetComponent<Inventory>(); }

    private void Update() { CheckIfAlpacasHaveBeenRescued(); }

    private void CheckIfAlpacasHaveBeenRescued()
    {
        if (_inventory.alpacasRescued == alpacasToRescue) { StartCoroutine("WaitBeforeMovingToMainMenu"); }
    }

    private IEnumerator WaitBeforeMovingToMainMenu()
    {
        victoryBanner.SetActive(true);
        
        yield return new WaitForSeconds(4);

        SceneManager.LoadScene(0);
    }
}

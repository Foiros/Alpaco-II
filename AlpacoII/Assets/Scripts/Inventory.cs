using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
   public int alpacasRescued;
   public List<int> combinationItems;

   public List<GameObject> inventoryImages;
   public List<bool> itemsGathered;

   public TextMeshProUGUI alpacaMeter;

   private void Start() { alpacaMeter.text = "Alpaca's rescued: " + alpacasRescued; }

   public void CollectItem(int i) 
   { 
      itemsGathered[i] = true;
      AddToInventory(i);
      CheckForCombinationItems(combinationItems[0], combinationItems[1], combinationItems[2], combinationItems[3]);
   }

   public void UseItem(int i) { RemoveFromInventory(i); }

   public void RescueAlpaca() 
   { 
      alpacasRescued++;
      alpacaMeter.text = alpacaMeter.text = "Alpaca's rescued: " + alpacasRescued; ;
   }

   private void RemoveFromInventory(int i)
   {
      itemsGathered[i] = false; 
      inventoryImages[i].SetActive(false);
   }
   
   private void AddToInventory(int i) { inventoryImages[i].SetActive(true); }

   private void CheckForCombinationItems(int i1, int i2, int i3, int i4)
   {
      if (itemsGathered[i1] && itemsGathered[i2] && itemsGathered[i3])
      {
         RemoveFromInventory(i1);
         RemoveFromInventory(i2);
         RemoveFromInventory(i3);
         
         AddToInventory(i4);
      }
   }
}

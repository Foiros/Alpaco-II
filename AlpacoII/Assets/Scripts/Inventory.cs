using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
   public int alpacasRescued;

   public int number1, number2, number3, number4, number5, number6;

   public List<GameObject> inventoryImages;
   public List<bool> itemsGathered;

   public TextMeshProUGUI alpacaMeter;

   private void Start() { alpacaMeter.text = "Alpaca's rescued: " + alpacasRescued; }
   

   public void CollectItem(int i) { AddToInventory(i); }

   public void UseItem(int i) { RemoveFromInventory(i); }

   public void RescueAlpaca(int itemID) 
   { 
      alpacasRescued++;
      alpacaMeter.text = alpacaMeter.text = "Alpaca's rescued: " + alpacasRescued; ;
      RemoveFromInventory(itemID);
   }

   private void RemoveFromInventory(int i)
   {
      itemsGathered[i] = false; 
      inventoryImages[i].SetActive(false);
   }
   
   private void AddToInventory(int i) 
   {  
      itemsGathered[i] = true; 
      inventoryImages[i].SetActive(true);

      CheckForCombinationItems(number1, number2, number3);
      CheckForCombinationItems(number4, number5, number6);
   }

   private void CheckForCombinationItems(int i1, int i2, int i3)
   {
      if (itemsGathered[i1] && itemsGathered[i2])
      {
         RemoveFromInventory(i1);
         RemoveFromInventory(i2);
         AddToInventory(i3);
      }
   }
}

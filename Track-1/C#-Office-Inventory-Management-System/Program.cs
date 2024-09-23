using System;
using System.Collections.Generic;

public class InventoryManagement
{
  public static void Main(string[] args){
    // Your code goes here
    List<string> inventoryList = new List<string> {
      "Printer", "Laptop", "Desk Chair", "Monitor",
      "Keyboard"
    };

    Console.WriteLine(inventoryList.Count);
    bool hasDeskChair = inventoryList.Contains("Desk Chair");
    Console.WriteLine(hasDeskChair);

    bool removed = inventoryList.Remove("Printer");
    Console.WriteLine(removed);

    foreach (string inventory in inventoryList) {
      Console.WriteLine(inventory);
    }

    List<string> newItems = new List<string> {
      "Mouse", "Desk Lamp"
    };

    inventoryList.AddRange(newItems);

    foreach (string inventory in inventoryList) {
      Console.WriteLine(inventory);
    }
    
    inventoryList.RemoveRange(3,2);

    List<string> topInventory = inventoryList.GetRange(0,3);

    foreach (string topItems in topInventory) {
      Console.WriteLine(topItems);
    }
  }
}
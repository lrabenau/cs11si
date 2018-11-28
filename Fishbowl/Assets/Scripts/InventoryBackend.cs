using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 



public class InventoryBackend : MonoBehaviour {
    public List<string> inventory = new List<string>();  

    public void addItem(string newItem)
    {
        inventory.Add(newItem); 
    }

    public bool containsItem(string item)
    {
        return inventory.Contains(item); 
    }

    public bool removeItem(string item)
    {
        return inventory.Remove(item); 
    }

}

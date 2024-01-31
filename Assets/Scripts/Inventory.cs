using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int maxInventorySize = 16;

    private Dictionary<string,InventoryItem> _inventory = new Dictionary<string, InventoryItem>();

    public void AddItem(InventoryItem item)
    {
        _inventory.Add(item.itemId, item);
        Debug.Log(_inventory);
    }
}

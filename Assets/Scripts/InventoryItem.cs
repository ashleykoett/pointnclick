using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItem : MonoBehaviour
{
    public string itemName;
    public string itemId;
    public string description;
    public Sprite icon;

    public string getName() { return itemName; }
    public string getDescription() { return description; }
    public Sprite getIcon() { return icon; }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddItemOnClick : MonoBehaviour
{
    public Inventory inventory;
    public InventoryItem item;

    private void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0) )
        {
            inventory.AddItem(item);
            Destroy(gameObject);
        }
    }
}

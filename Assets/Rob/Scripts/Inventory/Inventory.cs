using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private const int Slots = 10;
    public InventoryItem[] items = new InventoryItem[Slots];

    public int FindFreeSlot()
    {
        for(int i = 0; i < items.Length; i++)
        {
            if (items[i].isAvailable()) return i;
        }

        return -1;
    }

    public void AddItem(ShopItem item, int slot)
    {
        items[slot].Setup(item.image, null, item.name);       
    }
}

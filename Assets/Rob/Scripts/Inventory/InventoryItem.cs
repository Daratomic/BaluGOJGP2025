using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItem : MonoBehaviour
{
    public Image itemImage;

    private GameObject itemPrefab;
    private string itemName;

    private void Start()
    {
        Clear();
    }

    public void Clear()
    {
        itemName = "cleared";
    }

    public bool isAvailable()
    {
        return itemName == "cleared";
    }

    public void Setup(Sprite sprite, GameObject prefab, string iname)
    {
        itemPrefab = prefab;
        itemName = iname;

        itemImage.sprite = sprite;
    }
}

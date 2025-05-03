using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[Serializable]
public class ShopItem
{
    public int cost = 0;
    public string name = "NoName";
    public Sprite image;
    public GameObject prefab;
}

public class ShopManager : MonoBehaviour
{
    public TextMeshProUGUI totalCoins;
    public PiggyBank bank;
    public GameObject itemHolder;
    public List<ShopItem> items;
    public GameObject ShopItemPrefab;
    public Inventory inventory;

    private void Start()
    {
        for (int i = 0; i < items.Count; i++)
        {
            GameObject Shopitem = Instantiate(ShopItemPrefab);
            Shopitem.transform.SetParent(itemHolder.transform, false);
            var itemComponent = Shopitem.GetComponent<ShopItemInformation>();
            itemComponent.Setup(items[i]);
            itemComponent.OnItemButtonClicked += OnBuy;

        }
    }

    private void OnEnable()
    {
        totalCoins.SetText(bank.BankAmount.ToString());
    }

    public void OnBuy(string itemName)
    {
        ShopItem item = null;

        for(int i = 0; i < items.Count; i++)
        {
            if (items[i].name == itemName)
            {
                item = items[i];
                break;
            }
        }

        if (item == null) return;

        if(bank.CanAfford(item.cost))
        {
            int invSlot = inventory.FindFreeSlot();

            if (invSlot == -1) return;

            bank.SpendCoins(item.cost);

            inventory.AddItem(item, invSlot);

            Debug.Log("bought: " + item.name + " for " + item.cost + " coins.");
        }
    }
}

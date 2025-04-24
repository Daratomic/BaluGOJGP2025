using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShopItemInformation : MonoBehaviour
{
    public Image image;
    public TextMeshProUGUI costText;
    public Button button;

    private string _itemName;

    public event Action<string> OnItemButtonClicked;

    public void Setup(ShopItem itemInfo)
    {
        costText.text = itemInfo.cost.ToString();
        image.sprite = itemInfo.image;
        _itemName = itemInfo.name;
    }

    public void OnClicked()
    {
        OnItemButtonClicked.Invoke(_itemName);
    }
}

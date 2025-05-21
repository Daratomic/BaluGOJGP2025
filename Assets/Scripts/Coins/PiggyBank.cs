using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PiggyBank : MonoBehaviour
{
    public CoinManager manager;
    public TMP_Text totalCoins;
    //[SerializeField]
    //private int _bankAmount;

    public void Start()
    {
        totalCoins.SetText(ShopVariables.BankedCoins.ToString());
    }

    public int BankAmount
    {
        get;
    }

    public void AddCoinsToBank()
    {
        ShopVariables.BankedCoins += manager.getTotal();
        manager.resetTotal();
        totalCoins.SetText(ShopVariables.BankedCoins.ToString());
    }

    public bool CanAfford(int amount)
    {
        return ShopVariables.BankedCoins - amount >= 0;
    }

    public void SpendCoins(int amount)
    {
        ShopVariables.BankedCoins -= amount;
        totalCoins.SetText(ShopVariables.BankedCoins.ToString());
    }
}

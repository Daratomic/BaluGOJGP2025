using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PiggyBank : MonoBehaviour
{
    public CoinManager manager;
    public TMP_Text totalCoins;
    [SerializeField]
    private int _bankAmount;

    public int BankAmount
    {
        get;
    }

    public void AddCoinsToBank()
    {
        _bankAmount += manager.getTotal();
        manager.resetTotal();
        totalCoins.SetText(_bankAmount.ToString());
    }

    public bool CanAfford(int amount)
    {
        return _bankAmount - amount >= 0;
    }

    public void SpendCoins(int amount)
    {
        _bankAmount -= amount;
        totalCoins.SetText(_bankAmount.ToString());
    }
}

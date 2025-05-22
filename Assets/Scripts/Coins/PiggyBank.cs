using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PiggyBank : MonoBehaviour
{
    public CoinManager manager;
    public TMP_Text totalCoins;
    public AudioSource piggyBankAudio; // Reference to audio source

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

    // Call this when the piggy bank is clicked
    public void OnPiggyBankClicked()
    {
        if (piggyBankAudio != null)
        {
            piggyBankAudio.Play();
        }

        // Optionally call AddCoinsToBank() or other logic here
    }
}


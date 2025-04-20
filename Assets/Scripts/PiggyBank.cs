using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PiggyBank : MonoBehaviour
{
    public TMP_Text amount;
    int BankAmount;

    public void AddCoinsToBank()
    {
        BankAmount += CoinManager.CoinTally;
        CoinManager.CoinTally = 0;
        amount.SetText(BankAmount.ToString());
    }
}

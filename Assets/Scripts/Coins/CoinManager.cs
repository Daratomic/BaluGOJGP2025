using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public TMP_Text CoinString;
    private int CoinTally = 0;

    public void addCoins(int toAdd)
    {
        CoinTally += toAdd;
        CoinString.text = CoinTally.ToString();
    }

    public void addCoin()
    {
        addCoins(1);
    }

    public int getTotal()
    {
        return CoinTally;
    }

    public void resetTotal()
    {
        CoinTally = 0;
    }
}

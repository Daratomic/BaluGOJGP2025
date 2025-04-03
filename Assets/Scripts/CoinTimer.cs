using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinTimer : MonoBehaviour
{
    private float timer = 0f;
    private float DelayAmount = 1.0f;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= DelayAmount)
        {
            timer = 0f;
            CoinManager.CoinTally++;
        }
    }
}

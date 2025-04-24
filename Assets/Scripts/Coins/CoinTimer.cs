using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinTimer : MonoBehaviour
{
    public CoinManager manager;
    private float timer = 0f;
    private float DelayAmount = 1.0f;

    private void Start()
    {
        manager = GetComponent<CoinManager>();
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= DelayAmount)
        {
            timer = 0f;
            manager.addCoin();
        }
    }
}

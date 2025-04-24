using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Timers;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    void OnMouseDown()
    {
        //CoinsChance = Random.Range(1, 101);
        //if (CoinsChance > 95)
        //{
        //    CoinManager.CoinTally += 10;
        //}
        //else
        //{
        //    CoinManager.CoinTally += 5;
        //}
        Destroy(gameObject);
    }
}

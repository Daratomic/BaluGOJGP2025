using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    public GameObject turtles;
    public int CoinTally;
    // Start is called before the first frame update
    void Start()
    {
        CoinTally = 0;
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        GameObject.Destroy(turtles);
        CoinTally++;
    }
}

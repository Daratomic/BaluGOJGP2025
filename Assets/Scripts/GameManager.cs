using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class GameManager : MonoBehaviour
{
    public MovementScript turtlePrefab;

    private void Awake()
    {
        ObjectPooler.SetupPool(turtlePrefab, 10, "Turtle");
    }
}

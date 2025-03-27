using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CornSpawner : MonoBehaviour
{
    [SerializeField] GameObject SpawnObject;
    void Spawner()
    {
        if(SpawnObject != null)
        {
            Instantiate(SpawnObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

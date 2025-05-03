using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ObjectPooler
{
   static List<GameObject> Pool = new List<GameObject>();
    public static void AddToPool(GameObject item)
    {
        Pool.Add(item);
    }

    public static GameObject Get()
    {
        GameObject ToReturn = null;
        if(Pool.Count > 0)
        {
            ToReturn = Pool[0];
            Pool.RemoveAt(0);
        }

        return ToReturn;
    }

    public static void PutBack(GameObject Item)
    {
        Item.SetActive(false);
        Item.transform.position = new Vector3(2000,0,0);

        AddToPool(Item);
    }

}

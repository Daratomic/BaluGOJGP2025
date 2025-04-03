using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CornSpawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> turtles; // List of turtle prefabs that will be spawned
    [SerializeField] private Vector2 spawnPoint;
    [SerializeField] private int timeBetweenSpawns; // Time it takes for each object to spawn
    
    // Do NOT touch these in inspector
    public List<GameObject> turtlesInGame; // List of turtles currently in game

    // Update is called once per frame
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            int turtleNumber = Random.Range(0, turtles.Count);
            GameObject turtle = Instantiate(turtles[turtleNumber]);
            ObjectPooler.AddToPool(turtle);
        }
        StartCoroutine(BeginSpawner());
    }

    void SpawnTurtle()
    {
        GameObject SpawnsTurtle;
        SpawnsTurtle = ObjectPooler.Get();

        if (SpawnsTurtle == null)
        {
            return;
        }
        SpawnsTurtle.SetActive(true);
        turtlesInGame.Add(SpawnsTurtle);
    }

    IEnumerator Spawner()
    {
        while (true)
        {
            SpawnTurtle();
            yield return new WaitForSeconds(timeBetweenSpawns);
        }
    }

    IEnumerator BeginSpawner()
    {
        yield return new WaitForSeconds(4f);
        StartCoroutine(Spawner());
    }
}

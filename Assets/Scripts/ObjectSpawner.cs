using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> turtles; // List of turtle prefabs that will be spawned
    [SerializeField] private List<GameObject> corns;
    [SerializeField] private List<GameObject> spawnPoints;
    [SerializeField] private int timeBetweenSpawns; // Time it takes for each object to spawn
    
    // Do NOT touch these in inspector
    public List<GameObject> turtlesInGame; // List of turtles currently in game
    public List<GameObject> cornsInGame;

    // Update is called once per frame
    void Start()
    {
        StartCoroutine(BeginSpawner());
    }

    void SpawnTurtle()
    {
        int turtleNumber = Random.Range(0, turtles.Count); // Choose random turtle from list
        GameObject turtleObject = turtles[turtleNumber];
        GameObject turtleList = Instantiate(turtleObject, RandomSpawnPoint().position, Quaternion.identity);
        turtlesInGame.Add(turtleList);
    }

    void SpawnCorns()
    {
        int cornNumber = Random.Range(0, corns.Count); // Choose random turtle from list
        GameObject cornObject = corns[cornNumber];
        GameObject cornList = Instantiate(cornObject, RandomSpawnPoint().position, Quaternion.identity);
        cornsInGame.Add(cornList);
    }

    Transform RandomSpawnPoint()
    {
        // Random spawn point from list (This is to get it working. This will be refined)
        int spawnPointNumber = Random.Range(0, spawnPoints.Count);
        GameObject spawnPoint = spawnPoints[spawnPointNumber];
        return spawnPoint.transform;
    }

    IEnumerator Spawner()
    {
        while (true)
        {
            SpawnTurtle();
            SpawnCorns();
            yield return new WaitForSeconds(timeBetweenSpawns);
        }
    }

    IEnumerator BeginSpawner()
    {
        yield return new WaitForSeconds(4f);
        StartCoroutine(Spawner());
    }
}

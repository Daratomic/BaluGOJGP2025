using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> notes; // List of turtle prefabs that will be spawned
    [SerializeField] private List<GameObject> spawnPoints;
    [SerializeField] private int timeBetweenSpawns; // Time it takes for each object to spawn
    
    // Do NOT touch these in inspector
    public List<GameObject> notesInGame; // List of turtles currently in game
    public CoinManager manager;

    // Update is called once per frame
    void Start()
    {
        StartCoroutine(BeginSpawner());
    }

    void SpawnTurtle()
    {
        int turtleNumber = Random.Range(0, notes.Count); // Choose random turtle from list
        GameObject turtleObject = notes[turtleNumber];
        GameObject turtleList = Instantiate(turtleObject, RandomSpawnPoint().position, Quaternion.identity);
        notesInGame.Add(turtleList);
        turtleList.GetComponent<TurtleManager>().coinManager = manager;
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
            yield return new WaitForSeconds(timeBetweenSpawns);
        }
    }

    IEnumerator BeginSpawner()
    {
        yield return new WaitForSeconds(4f);
        StartCoroutine(Spawner());
    }
}

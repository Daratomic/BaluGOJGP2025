using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CornSpawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> corn; // List of corn prefabs that will be spawned
    [SerializeField] private List<GameObject> turtles; // List of turtle prefabs that will be spawned
    [SerializeField] private List<GameObject> spawnPoints;
    [SerializeField] private int timeBetweenSpawns; // Time it takes for each object to spawn
    
    // Do NOT touch these in inspector
    public List<GameObject> cornsInGame; // List of corn prefabs currently in game
    public List<GameObject> turtlesInGame; // List of turtles currently in game

    // Update is called once per frame
    void Start()
    {
        StartCoroutine(BeginSpawner());
    }

    void SpawnTurtle()
    {
        int turtleNumber = Random.Range(0, turtles.Count); // Chooses random turtle to spawn
        GameObject turtle = turtles[turtleNumber];
        
        GameObject turtleInGame = Instantiate(turtle, RandomSpawnPoint().position, Quaternion.identity); // Spawns Object at random point
        turtlesInGame.Add(turtleInGame); // Add turtle to the list of turtles in game
    }

    void SpawnCorn()
    {
        // Same as before but with Corn
        int cornNumber = Random.Range(0, corn.Count);
        GameObject corns = corn[cornNumber]; 
        
        GameObject cornInGame = Instantiate(corns, RandomSpawnPoint().position, Quaternion.identity);
        cornsInGame.Add(cornInGame);
    }

    Transform RandomSpawnPoint()
    {
        int spawnPointNumber = Random.Range(0, spawnPoints.Count);
        GameObject spawnPointObj = spawnPoints[spawnPointNumber];
        return spawnPointObj.transform;
    }

    IEnumerator Spawner()
    {
        SpawnTurtle();
        yield return new WaitForSeconds(timeBetweenSpawns);
        SpawnCorn();
        yield return new WaitForSeconds(timeBetweenSpawns);
        SpawnTurtle();
        yield return new WaitForSeconds(timeBetweenSpawns);
        SpawnCorn();
        yield return new WaitForSeconds(timeBetweenSpawns);
        SpawnTurtle();
        yield return new WaitForSeconds(timeBetweenSpawns);
        SpawnCorn();
        yield return new WaitForSeconds(timeBetweenSpawns);
        StartCoroutine(Spawner());
    }

    IEnumerator BeginSpawner()
    {
        yield return new WaitForSeconds(2.3f);
        StartCoroutine(Spawner());
    }
}

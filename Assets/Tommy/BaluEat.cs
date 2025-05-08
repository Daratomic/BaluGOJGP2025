using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaluEat : MonoBehaviour
{

    [SerializeField] private List<GameObject> note; // List of turtle prefabs that will be spawned
    [SerializeField] private List<GameObject> spawnPoints;
    [SerializeField] private int timeBetweenSpawns; // Time it takes for each object to spawn

    public float speed = 1;
    public Vector3 target = new Vector3(48.7f, 51.07f, 102.8f);
    private bool moving = false;


    public List<GameObject> notesInGame; // List of turtles currently in game

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (moving)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target, step);
        }
    }


    void spawnNote()
    {
        int noteNumber = Random.Range(0, note.Count); // Choose random turtle from list
        GameObject noteObject = note[noteNumber];
        GameObject noteList = Instantiate(noteObject, RandomSpawnPoint().position, Quaternion.identity);
        notesInGame.Add(noteList);

    }

    Transform RandomSpawnPoint()
    {
        // Random spawn point from list (This is to get it working. This will be refined)
        int spawnPointNumber = Random.Range(0, spawnPoints.Count);
        GameObject spawnPoint = spawnPoints[spawnPointNumber];
        return spawnPoint.transform;
    }


}

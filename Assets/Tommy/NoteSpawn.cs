using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class NoteSpawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> notes; // List of notes prefabs that will be spawned
    [SerializeField] private List<GameObject> spawnPoints;
    [SerializeField] private int timeBetweenSpawns; // Time it takes for each object to spawn
    [SerializeField] public Transform targetLocation;
    public Slider progressBar; // Reference to the UI progress bar
    public float progressIncrease = 0.1f; // Amount to increase the bar

    // Do NOT touch these in inspector
    public List<GameObject> notesInGame; // List of notes currently in game

    // Update is called once per frame
    void Start()
    {
        StartCoroutine(BeginSpawner());
    }

    private void Update()
    {
        // Check if the object has reached the target location
        if (Vector3.Distance(transform.position, targetLocation.position) < 0.1f)
        {
            // Increase progress bar value
            if (progressBar != null)
            {
                progressBar.value += progressIncrease;
            }

            // Destroy the object
            Destroy(gameObject);
        }
    }

    void SpawnNote()
    {
        int noteNumber = Random.Range(0, notes.Count); // Choose random notes from list
        GameObject noteObject = notes[noteNumber];
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

    IEnumerator Spawner()
    {
        while (true)
        {
            SpawnNote();
            yield return new WaitForSeconds(timeBetweenSpawns);
        }
    }

    IEnumerator BeginSpawner()
    {
        yield return new WaitForSeconds(4f);
        StartCoroutine(Spawner());
    }


}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
//using UnityEngine.UIElements;
using UnityEngine.UI;
using static UnityEngine.GraphicsBuffer;

public class NoteSpawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> notes; // List of notes prefabs that will be spawned
    [SerializeField] private List<GameObject> spawnPoints;
    [SerializeField] private float timeBetweenSpawns; // Time it takes for each object to spawn
    [SerializeField] public Transform targetLocation;
    [SerializeField] public Slider progressBar; // Reference to the UI progress bar
    [SerializeField] public float progressIncrease = 0.1f; // Amount to increase the bar
    [SerializeField] public Button startButton;
    [SerializeField] public float movementSpeed = 0.1f;

    // Do NOT touch these in inspector
    public List<GameObject> notesInGame; // List of notes currently in game

    // Update is called once per frame
    void Start()
    {
      
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


        }
        MoveGameObject();
    }
    void MoveGameObject()

    {
        float step = movementSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, targetLocation.position, step);
    }

    void SpawnNote()
    {
        int noteNumber = Random.Range(0, notes.Count); // Choose random notes from list
        GameObject noteObject = notes[noteNumber];
        GameObject noteList = Instantiate(noteObject, RandomSpawnPoint().position, Quaternion.identity);
        notesInGame.Add(noteList);

        noteList.GetComponent<NoteMovement>().targetLocation = targetLocation;
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


        yield return new WaitForSeconds(5f);
        StartCoroutine(Spawner());
    }

    public void OnButtonClick()
    {

        StartCoroutine(Spawner());
        startButton.gameObject.SetActive(false);

    }

    
}

using UnityEngine;

public class BaluSpawner : MonoBehaviour
{
    public GameObject objectToSpawn; // Assign your prefab in the Inspector
    public Transform spawnPoint; // Assign a spawn position in the Inspector

    public void SpawnBalu()
    {
        if (objectToSpawn != null && spawnPoint != null)
        {
            Instantiate(objectToSpawn, spawnPoint.position, spawnPoint.rotation);
        }
    }
}
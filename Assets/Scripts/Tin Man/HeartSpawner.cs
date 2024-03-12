using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartSpawner : MonoBehaviour
{
    public GameObject heartPrefab; // Assign the heart prefab in the Unity editor
    public float spawnInterval = 2f; // Interval between each heart spawn
    public Transform spawnPoint; // The position where hearts will spawn

    private void Start()
    {
        // Call the SpawnHeart method repeatedly at specified intervals
        InvokeRepeating("SpawnHeart", 0f, spawnInterval);
    }

    private void SpawnHeart()
    {
        // Instantiate a heart object at the spawn point
        Instantiate(heartPrefab, spawnPoint.position, Quaternion.identity);
    }
}

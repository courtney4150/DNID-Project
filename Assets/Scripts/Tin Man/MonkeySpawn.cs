using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkeySpawn : MonoBehaviour
{
    public GameObject[] fallingObjectPrefabs;
    public float spawnInterval = 1f;

    void Start()
    {
        StartCoroutine(SpawnObjectsWithDelay());
    }

    IEnumerator SpawnObjectsWithDelay()
    {
        while (true)
        {
            // Randomly select a falling object prefab
            GameObject prefab = fallingObjectPrefabs[Random.Range(0, fallingObjectPrefabs.Length)];

            // Instantiate the selected prefab at the spawn point
            Instantiate(prefab, transform.position, Quaternion.identity);

            // Wait for the specified spawn interval before spawning the next object
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}


// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class FlyingMonkey : MonoBehaviour
// {
//     public GameObject[] monkeyPrefab;
//     public float secondSpawn = 1f; 
//     [SerializeField] float minTras;
//     [SerializeField] float maxTras;

//     //Calls the TMC
//     public TinManController controller;

//     void Start(){
//         InvokeRepeating("SpawnObject", 0f, spawnInterval);
//     }

//     void SpawnObject()
//     {
//         // Randomly select a falling object prefab
//         GameObject prefab = fallingObjectPrefabs[Random.Range(0, fallingObjectPrefabs.Length)];

//         // Get the screen boundaries in world space
//         float screenX = Random.Range(Camera.main.ScreenToWorldPoint(Vector3.zero).x, Camera.main.ScreenToWorldPoint(Vector3.right * Screen.width).x);

//         // Calculate spawn position above the screen
//         Vector3 spawnPosition = new Vector3(screenX, Camera.main.ScreenToWorldPoint(Vector3.up * Screen.height).y, 0f);

//         // Instantiate the selected prefab at the random position
//         Instantiate(prefab, spawnPosition, Quaternion.identity);

//         Destroy(gameObject, 5f);
//     }

//     // IEnumerator MonkeySpawn(){
//     //     while(true){
//     //         var wanted = Random.Range(minTras, maxTras);
//     //         var position = new Vector3(wanted, transform.position.y); 
//     //         int random = Random.Range(0, monkeyPrefab.Length);
//     //         Debug.Log("Prefab length is: " + monkeyPrefab.Length);
//     //         Debug.Log("Random index: " + random);
//     //         GameObject gameObject = Instantiate(monkeyPrefab[random], position, Quaternion.identity);
//     //         yield return new WaitForSeconds(secondSpawn);
//     //         Destroy(gameObject, 5f);
//     //     }
//     // }

//     private void OnTriggerEnter2D(Collider2D collision){
//         if(collision.gameObject.name == "TinManSprite"){
//             Destroy(gameObject);
//             controller.TakeDamage(1);
//         }
//     }
// }

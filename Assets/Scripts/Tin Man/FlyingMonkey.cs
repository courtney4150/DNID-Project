using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingMonkey : MonoBehaviour
{
    private int lifeCount = 3;
    [SerializeField] GameObject[] monkeyPrefab;
    [SerializeField] float secondSpawn = 0.5f; 
    [SerializeField] float minTras;
    [SerializeField] float maxTras;

    void Start(){
        StartCoroutine(MonkeySpawn());
    }

    IEnumerator MonkeySpawn(){
        while(true){
            var wanted = Random.Range(minTras, maxTras);
            var position = new Vector3(wanted, transform.position.y); 
            int random = Random.Range (0, monkeyPrefab.Length);
            Debug.Log("Prefab length is: " + monkeyPrefab.Length);
            GameObject gameObject = Instantiate(monkeyPrefab[random], 
            position, Quaternion.identity);
            yield return new WaitForSeconds(secondSpawn);
            Destroy(gameObject, 5f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.name == "TinManSprite"){
            Debug.Log("hit");
            Destroy(gameObject);
            lifeCount--; 
            Debug.Log("Lives: " + lifeCount);
        }
    }
}

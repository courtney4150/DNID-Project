using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectHeart : MonoBehaviour
{
    public float minRespawnDelay = 3f;
    public float maxRespawnDelay = 10f;
    public HeartManager hm;
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.name == "TinManSprite"){
            gameObject.SetActive(false);
            hm.heartCount += 1;
            float respawnDelay = Random.Range(minRespawnDelay, maxRespawnDelay);
            Invoke("RespawnObject", respawnDelay);
        }
    }

    private void RespawnObject()
    {
        gameObject.SetActive(true); // Reactivate the object
    }
}
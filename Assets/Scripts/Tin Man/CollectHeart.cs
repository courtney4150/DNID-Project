using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectHeart : MonoBehaviour
{
    private int heart;
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.name == "TinManSprite"){
            Debug.Log("You got the heart");
            Destroy(gameObject);
            heart++;
        }Debug.Log("Heart: "+ heart);
    }
}
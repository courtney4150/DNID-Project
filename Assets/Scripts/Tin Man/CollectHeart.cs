using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectHeart : MonoBehaviour
{
    private Object thisObject; 

    private void Awake(){
        thisObject = GetComponent<Object>();
    }

    private void OnTriggerEnter2D(Collider2D collision){
		if(collision.gameObject.CompareTag("PlayerCollider")){
            Debug.Log("Heart collected!");
			Destroy(collision.gameObject);
		}
	}
}
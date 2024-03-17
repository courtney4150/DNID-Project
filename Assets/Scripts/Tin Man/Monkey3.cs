using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monkey3 : MonoBehaviour
{
    public float minSpeed = 3f;
    public float maxSpeed = 15f;

    public TinManController controller;

    void Start()
    {
        transform.position = new Vector3(Random.Range(-5f, 5f), 10f, 0f);
        float speed = Random.Range(minSpeed, maxSpeed);
        GetComponent<Rigidbody2D>().velocity = Vector2.down * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "TinManSprite"){
            controller.TakeDamage(1);
            gameObject.SetActive(false);
        }
    }
}

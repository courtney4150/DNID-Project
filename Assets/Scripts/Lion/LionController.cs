using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class LionController : MonoBehaviour
{
    public float speed = 5;
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // transform.position += Vector3.right * speed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * 26.6581f, ForceMode2D.Impulse);

        }
    }

}
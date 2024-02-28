using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DorothyController : MonoBehaviour
{
    public float speed;
    private Vector2 newPos;
    private float x, y;
    

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
        if ((Input.GetKey(KeyCode.LeftArrow)) & !(pos.x < 0.05))
            x = gameObject.transform.position.x - (speed * Time.deltaTime);
            y = gameObject.transform.position.y;
            newPos = new Vector2(x, y);
            gameObject.transform.position = newPos;

        if ((Input.GetKey(KeyCode.RightArrow)) & !(pos.x > 0.95))
            x = gameObject.transform.position.x + (speed * Time.deltaTime);
            y = gameObject.transform.position.y;
            newPos = new Vector2(x, y);
            gameObject.transform.position = newPos;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "crap")
        {
            SceneManager.LoadScene("level2");
        }

        
    }
}

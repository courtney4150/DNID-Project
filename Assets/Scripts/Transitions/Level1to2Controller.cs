using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1to2Controller: MonoBehaviour
{
    public int speed;
    private Vector2 newPos;
    private float x, y;

    // Update is called once per frame
    void Update()
    {

        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
        if ((Input.GetKey(KeyCode.LeftArrow)) & !(pos.x < 0.05))
        {
            x = gameObject.transform.position.x - (speed * Time.deltaTime);
            y = gameObject.transform.position.y;
            newPos = new Vector2(x, y);
            gameObject.transform.position = newPos;
        }

        if ((Input.GetKey(KeyCode.RightArrow)) & !(pos.x > 0.95))
        {
            x = gameObject.transform.position.x + (speed * Time.deltaTime);
            y = gameObject.transform.position.y;
            newPos = new Vector2(x, y);
            gameObject.transform.position = newPos;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("up key pressed");
            x = gameObject.transform.position.x;
            y = gameObject.transform.position.y + (speed * Time.deltaTime);
            newPos = new Vector2(x, y);
            gameObject.transform.position = newPos;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            x = gameObject.transform.position.x;
            y = gameObject.transform.position.y - (speed * Time.deltaTime);
            newPos = new Vector2(x, y);
            gameObject.transform.position = newPos;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Level2Icon")
        {
            SceneManager.LoadScene("ScareCrow");
        }
    }



}

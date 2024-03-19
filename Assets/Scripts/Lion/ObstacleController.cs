using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleController : MonoBehaviour
{
    private Vector2 newPos;
    private float x, y;
    public float speed;
    public float timeElapsed;

    // Update is called once per frame
    void Update()
    {
        x = gameObject.transform.position.x - (speed * Time.deltaTime);
        y = gameObject.transform.position.y;
        newPos = new Vector2(x, y);
        gameObject.transform.position = newPos;

        timeElapsed += Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "LionSprite")
        {
            SceneManager.LoadScene("Level4");
        }
    }

}
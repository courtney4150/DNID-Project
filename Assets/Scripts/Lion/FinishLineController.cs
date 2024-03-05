using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLineController : MonoBehaviour
{
    private Vector2 newPos;
    private float x, y;
    public float speed;
    public float timeElapsed;
    public float gameTimeElapsed;

    // Update is called once per frame
    void Update()
    {
        if (gameTimeElapsed >= 10)
        {
            x = gameObject.transform.position.x - (speed * Time.deltaTime);
            y = gameObject.transform.position.y;
            newPos = new Vector2(x, y);
            gameObject.transform.position = newPos;
        }
        
        timeElapsed += Time.deltaTime;
        gameTimeElapsed += Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "LionSprite")
        {
            SceneManager.LoadScene("home");
        }
    }

}
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
        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
        if (gameTimeElapsed >= 30)
        {
            x = gameObject.transform.position.x - (speed * Time.deltaTime);
            y = gameObject.transform.position.y;
            newPos = new Vector2(x, y);
            gameObject.transform.position = newPos;
        }
        
        timeElapsed += Time.deltaTime;
        gameTimeElapsed += Time.deltaTime;

        if (pos.x < 0.05)
        {
            SceneManager.LoadScene("end");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "LionSprite")
        {
            //Debug.Log("collided with lion");
            SceneManager.LoadScene("Transition4toEC");
        }
    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1to2Controller: MonoBehaviour
{
    public int speed;
    private Vector2 newPos;
    private float x, y;
    public float timeElapsed;

    // Update is called once per frame
    void Update()
    {
        if (timeElapsed <= 8)
        {
            x = gameObject.transform.position.x + (speed * Time.deltaTime);
            y = gameObject.transform.position.y;
            newPos = new Vector2(x, y);
            gameObject.transform.position = newPos;
        }
        else
        {
            SceneManager.LoadScene("Level2");
        }
        timeElapsed += Time.deltaTime;

    }
}

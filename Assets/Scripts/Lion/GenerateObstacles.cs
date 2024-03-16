using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObstacles : MonoBehaviour
{
    public float speed;
    public float timeElapsed;
    public float gameTimeElapsed;
    public GameObject obstacle;
    public GameObject finishLine;


    void Update()
    {
        timeElapsed += Time.deltaTime;
        gameTimeElapsed += Time.deltaTime;

        float triggerTime = Random.Range(1, 10);

        if (timeElapsed >= triggerTime && gameTimeElapsed <= 10)
        {
            Instantiate(obstacle, gameObject.transform.position, Quaternion.identity);
            timeElapsed = 0;
        }
    }
}

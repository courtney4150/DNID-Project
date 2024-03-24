using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObstacles : MonoBehaviour
{
    public float speed;
    public float timeElapsed;
    public float gameTimeElapsed;
    public GameObject obstacle1;
    public GameObject obstacle2;

    public GameObject finishLine;


    void Update()
    {
        timeElapsed += Time.deltaTime;
        gameTimeElapsed += Time.deltaTime;

        float triggerTime = Random.Range(3, 6);
        float objectNum = Random.Range(1, 3);

        if (timeElapsed >= triggerTime && gameTimeElapsed <= 30)
        {
            if (objectNum == 1)
            {
                Instantiate(obstacle1, gameObject.transform.position, Quaternion.identity);
            }
            else if (objectNum == 2)
            {
                Instantiate(obstacle2, gameObject.transform.position, Quaternion.identity);
            }

            timeElapsed = 0;
        }
    }
}

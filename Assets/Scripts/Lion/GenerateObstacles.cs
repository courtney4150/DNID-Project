using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObstacles : MonoBehaviour
{
    public float speed;
    public float timeElapsed;
    public GameObject obstacle;


    void Update()
    {
        timeElapsed += Time.deltaTime;
        float triggerTime = Random.Range(1, 10);

        if (timeElapsed >= triggerTime)
        {
            Instantiate(obstacle, gameObject.transform.position, Quaternion.identity);
            timeElapsed = 0;
        }
    }
}

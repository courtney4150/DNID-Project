using UnityEngine;
using System.Collections;

public class TornadoController : MonoBehaviour
{
    private Vector2 newPos;
    private float x, y;
    private int direction = -1;
    public float speed;
    public float timeElapsed;
    public GameObject flyingObjectPrefab1;
    public GameObject flyingObjectPrefab2;
    public GameObject flyingObjectPrefab3;

    // Update is called once per frame
    void Update()
    {
        // if(gameObject.transform.position.x < -9 || gameObject.transform.position.x > 9)
        // {
        //     direction *= -1;
        // }

        x = gameObject.transform.position.x + direction * (speed * Time.deltaTime);
        y = gameObject.transform.position.y;
        newPos = new Vector2(x, y);
        gameObject.transform.position = newPos;

        timeElapsed += Time.deltaTime;
        float triggerTime = Random.Range(2, 6);
        float objectNum = Random.Range(1, 4);

        if (timeElapsed >= triggerTime)
        {
            if (objectNum == 1)
            {
                Instantiate(flyingObjectPrefab1, gameObject.transform.position, Quaternion.identity);
                
            }
            else if (objectNum == 2)
            {
                Instantiate(flyingObjectPrefab2, gameObject.transform.position, Quaternion.identity);
            }

            else if (objectNum == 3)
            {
                Instantiate(flyingObjectPrefab3, gameObject.transform.position, Quaternion.identity);
            }

            timeElapsed = 0;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "RightCollider")
        {
            
            direction *= -1;
        
        }

        if (collision.gameObject.name == "LeftCollider")
        {
            Debug.Log("Collided!");
            direction *= -1;
        }
    }
}

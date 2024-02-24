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

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.x <= -10 || gameObject.transform.position.x >= 10)
        {
            direction *= -1;
        }

        x = gameObject.transform.position.x + direction * (speed * Time.deltaTime);
        y = gameObject.transform.position.y;
        newPos = new Vector2(x, y);
        gameObject.transform.position = newPos;

        timeElapsed += Time.deltaTime;
        float triggerTime = Random.Range(2, 6);
        float objectNum = Random.Range(1, 3);

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
            
            timeElapsed = 0;
        }
    }
}

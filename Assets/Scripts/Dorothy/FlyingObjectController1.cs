using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingObjectController1 : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "DorothySprite")
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.name == "ground")
        {
            Destroy(gameObject);
        }
    }
}

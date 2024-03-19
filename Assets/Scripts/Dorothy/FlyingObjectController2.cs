using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingObjectController2 : MonoBehaviour
{

    public AudioSource myAudioSource;
    public AudioClip myAudioClip;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "DorothySprite")
        {
            myAudioSource.PlayOneShot(myAudioClip);
            Destroy(gameObject);
        }

        if (collision.gameObject.name == "ground")
        {
            Destroy(gameObject);
        }
    }
}

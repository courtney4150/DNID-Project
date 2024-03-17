using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BrainScript : MonoBehaviour
{
    public bool collected = false;

    // Reset the brain sprite to its initial position
    public void ResetBrain()
    {
        collected = false;
        gameObject.SetActive(true); // Reactivate the brain sprite
    }

    // Mark the brain sprite as collected and deactivate it
    public void CollectBrain()
    {
        collected = true;
        gameObject.SetActive(false); // Deactivate the brain sprite
        //Debug.Log("collected brain in KeyCont.cs");
    }

    // Check if the brain sprite has been collected
    public bool IsCollected()
    {
        return collected;
    }

    // Check if the brain sprite has been reset
    public bool IsReset()
    {
        return !gameObject.activeSelf;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("in KeyCont: hit " + gameObject.name);
        if (other.CompareTag("ScareCrow"))
        {
            CollectBrain();
        }
    }

}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DorothyDialogue : MonoBehaviour
{
    public GameObject speechBubblePrefab; // Reference to the speech bubble prefab

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "OtherItem")
        {
            ShowSpeechBubble();
        }
    }

    private void ShowSpeechBubble()
    {
        // Instantiate the speech bubble prefab
        GameObject speechBubble = Instantiate(speechBubblePrefab, transform.position, Quaternion.identity);

        // Parent the speech bubble to the canvas or relevant UI container
        speechBubble.transform.SetParent(GameObject.Find("Canvas").transform, false);

        // You may need to adjust the position of the speech bubble relative to the colliding object
        // For example, you could use speechBubble.transform.localPosition to set its position relative to the parent canvas.
    }
}
}

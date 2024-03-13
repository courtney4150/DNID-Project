using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BrainManager : MonoBehaviour
{
    public Transform mazeResetPoint; // Reset point for brain sprites when ScareCrow hits maze walls
    public GameObject[] brainSprites; // Array of brain sprite GameObjects
    public GameObject endDorothy; // Dorothy sprite GameObject at the end

    private List<BrainScript> collectedBrains = new List<BrainScript>();

    private void Start()
    {
        // Find all brain scripts in the scene and add them to the list
        foreach (GameObject brain in brainSprites)
        {
            collectedBrains.Add(brain.GetComponent<BrainScript>());
        }
    }

    private void Update()
    {
        // Check if all brain sprites have been collected
        if (collectedBrains.Count == brainSprites.Length)
        {
            // Load the scene for reaching Dorothy at the end
            SceneManager.LoadScene("Temporary Transition");
        }
    }

    // Reset all brain sprites to their initial positions
    public void ResetBrains()
    {
        foreach (BrainScript brain in collectedBrains)
        {
            if (!brain.IsReset())
            {
                brain.ResetBrain();
                brain.transform.position = mazeResetPoint.position;
            }
        }
    }
}
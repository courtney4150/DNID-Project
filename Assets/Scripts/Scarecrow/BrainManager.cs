using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System.Linq;

public class BrainManager : MonoBehaviour
{
    public Transform mazeResetPoint; // Reset point for brain sprites when ScareCrow hits maze walls
    public GameObject[] brainSprites; // Array of brain sprite GameObjects
    public GameObject endDorothy; // Dorothy sprite GameObject at the end
    private List<BrainScript> collectedBrains = new List<BrainScript>();

    public BrainScript brainScriptRef1, brainScriptRef2, brainScriptRef3, brainScriptRef4, brainScriptRef5,
        brainScriptRef6, brainScriptRef7, brainScriptRef8, brainScriptRef9, brainScriptRef10,
        brainScriptRef11, brainScriptRef12, brainScriptRef13, brainScriptRef14, brainScriptRef15;

    private List<BrainScript> totalBrainsCollected = new List<BrainScript>();
    public int numBrainsCollected;
    public int brainCount;
    public TMP_Text brainCountText;


    private void Start()
    {
        // Find all brain scripts in the scene and add them to the list
        foreach (GameObject brain in brainSprites)
        {
            collectedBrains.Add(brain.GetComponent<BrainScript>());
        }

        brainCount = 0;



        brainCountText.SetText("Brains collected: " + numBrainsCollected + "/15");
        

    }

    private void Update()
    {

        if (brainScriptRef1.collected && !totalBrainsCollected.Contains(brainScriptRef1))
        {
            totalBrainsCollected.Add(brainScriptRef1);
        }
        else if (brainScriptRef2.collected && !totalBrainsCollected.Contains(brainScriptRef2))
        {
            totalBrainsCollected.Add(brainScriptRef2);
        }
        else if (brainScriptRef3.collected && !totalBrainsCollected.Contains(brainScriptRef3))
        {
            totalBrainsCollected.Add(brainScriptRef3);
        }
        else if (brainScriptRef4.collected && !totalBrainsCollected.Contains(brainScriptRef4))
        {
            totalBrainsCollected.Add(brainScriptRef4);
        }
        else if (brainScriptRef5.collected && !totalBrainsCollected.Contains(brainScriptRef5))
        {
            totalBrainsCollected.Add(brainScriptRef5);
        }
        else if (brainScriptRef6.collected && !totalBrainsCollected.Contains(brainScriptRef6))
        {
            totalBrainsCollected.Add(brainScriptRef6);
        }
        else if (brainScriptRef7.collected && !totalBrainsCollected.Contains(brainScriptRef7))
        {
            totalBrainsCollected.Add(brainScriptRef7);
        }
        else if (brainScriptRef8.collected && !totalBrainsCollected.Contains(brainScriptRef8))
        {
            totalBrainsCollected.Add(brainScriptRef8);
        }
        else if (brainScriptRef9.collected && !totalBrainsCollected.Contains(brainScriptRef9))
        {
            totalBrainsCollected.Add(brainScriptRef9);
        }
        else if (brainScriptRef10.collected && !totalBrainsCollected.Contains(brainScriptRef10))
        {
            totalBrainsCollected.Add(brainScriptRef10);
        }
        else if (brainScriptRef11.collected && !totalBrainsCollected.Contains(brainScriptRef11))
        {
            totalBrainsCollected.Add(brainScriptRef11);
        }
        else if (brainScriptRef12.collected && !totalBrainsCollected.Contains(brainScriptRef12))
        {
            totalBrainsCollected.Add(brainScriptRef12);
        }
        else if (brainScriptRef13.collected && !totalBrainsCollected.Contains(brainScriptRef13))
        {
            totalBrainsCollected.Add(brainScriptRef13);
        }
        else if (brainScriptRef14.collected && !totalBrainsCollected.Contains(brainScriptRef14))
        {
            totalBrainsCollected.Add(brainScriptRef14);
        }
        else if (brainScriptRef15.collected && !totalBrainsCollected.Contains(brainScriptRef15))
        {
            totalBrainsCollected.Add(brainScriptRef15);
        }




        numBrainsCollected = totalBrainsCollected.Distinct().Count();
        //Debug.Log(numBrainsCollected);
        brainCountText.SetText("Brains collected: " + numBrainsCollected + "/15");

   
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "DorothySprite" && numBrainsCollected == 15)
        {
            SceneManager.LoadScene("Transition2to3");
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
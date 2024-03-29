using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovePlayer : MonoBehaviour
{
    public static string havekey = "n";
    public static string havefriend = "n";

    public GameObject teleportEffectPrefab; // Prefab for teleportation effect

    private Vector3 startingPosition;


    public BrainManager brainManagerRef;



    // Start is called before the first frame update
    void Start()
    {
        startingPosition = transform.position;

    }

    void Update()
    {
        // Get the horizontal and vertical input axes
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Apply a speed factor to the input axes to slow down the movement
        float speedFactor = 5; // Adjust this value to control the movement speed

        Vector2 movement = new Vector2(horizontalInput * speedFactor, verticalInput * speedFactor);

        // Set the player's velocity based on the modified movement vector
        GetComponent<Rigidbody2D>().velocity = movement;

        

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.name == "DorothySprite" && brainManagerRef.numBrainsCollected == 15)
        {
            SceneManager.LoadScene("ScarecrowWin");
        }
    }

    // Coroutine for teleporting to starting position with effects
    private IEnumerator TeleportToStartingPosition()
    {
        // Play teleportation effect
        if (teleportEffectPrefab != null)
        {
            Instantiate(teleportEffectPrefab, transform.position, Quaternion.identity);
        }

        // Wait for a short duration for the effect to play
        yield return new WaitForSeconds(0.5f);

        // Teleport the player to the starting position
        transform.position = startingPosition;
    }
}
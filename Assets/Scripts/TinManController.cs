using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TinManController : MonoBehaviour
{
    public float speed = 10f;
    public float jumpForce = 500f; // Adjust the jump force as needed
    private Rigidbody2D rb;
    private bool isGrounded;

    private float minX, maxX, minY, maxY;

    //Life Tracking variables
    public int health;
    public int maxHealth = 3;

    void Start()
    {
        //Life Tracking
        health = maxHealth;

        rb = GetComponent<Rigidbody2D>();

        // Get the screen boundaries in world space
        Vector3 lowerLeftCorner = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0));
        Vector3 upperRightCorner = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));

        // Define boundaries based on the screen's edges
        minX = lowerLeftCorner.x;
        maxX = upperRightCorner.x;
        minY = lowerLeftCorner.y;
        maxY = upperRightCorner.y;
    }

    void Update()
    {
        // Get player input for movement
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Calculate new position based on input and speed
        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0);
        transform.position += new Vector3(movement.x * speed * Time.deltaTime, movement.y * speed * Time.deltaTime, 0);

        // Clamp player position to stay within the boundaries
        float clampedX = Mathf.Clamp(transform.position.x, minX, maxX);
        float clampedY = Mathf.Clamp(transform.position.y, minY, maxY);
        transform.position = new Vector3(clampedX, clampedY, transform.position.z);

        // Jump mechanic
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce);
            isGrounded = false;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the Tin Man is grounded
        if (collision.gameObject.CompareTag("Platform"))
        {
            isGrounded = true;
        }
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            SceneManager.LoadScene("p.tin_man");
        }
    }
}

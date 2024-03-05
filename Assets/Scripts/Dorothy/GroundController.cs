using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GroundController : MonoBehaviour
{
    public int score;
    public TMP_Text scoreText;

    private void Start()
    {
        score = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        score++;
        scoreText.SetText("Score: " + score);

        if (score >= 20)
        {
            SceneManager.LoadScene("Transition1to2");
        }
    }
}

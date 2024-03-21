using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class HeartManager : MonoBehaviour
{
    public int heartCount;
    public TMP_Text heartText;

    void Update()
    {
        heartText.text = "Hearts Collected: " + heartCount.ToString() +"/15";

        if (heartCount >= 15)
        {
            SceneManager.LoadScene("TinManWin");
        }
    }

}



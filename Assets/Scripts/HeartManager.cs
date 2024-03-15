using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class HeartManager : MonoBehaviour
{
    public int heartCount;
    public Text heartText;

    void Update()
    {
        heartText.text = "Hearts Collected: " + heartCount.ToString();
    }

}



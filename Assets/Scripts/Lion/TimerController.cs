using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerController : MonoBehaviour
{
    public TMP_Text timer;
    public float time_left;


    // Start is called before the first frame update
    void Start()
    {
        time_left = 32;
    }

    // Update is called once per frame
    void Update()
    {
        time_left -= Time.deltaTime;
        timer.SetText(string.Format("{0:00}", Mathf.RoundToInt(time_left)));
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartController : MonoBehaviour
{
    int n;
    public void OnButtonPress()
    {
        n++;
        Debug.Log("Button clicked " + n + " times.");
        SceneManager.LoadScene("Level1");
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start2 : MonoBehaviour
{
    public void OnButtonPress()
    {
        SceneManager.LoadScene("Level2");
    }
}

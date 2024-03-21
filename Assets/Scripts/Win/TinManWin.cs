using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TinManWin : MonoBehaviour
{
    public void OnButtonPress()
    {
        SceneManager.LoadScene("Transition3to4");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScarecrowWin : MonoBehaviour
{
    public void OnButtonPress()
    {
        SceneManager.LoadScene("Transition2to3");
    }
}
